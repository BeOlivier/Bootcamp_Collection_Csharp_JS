using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Salt.Stars.API.Services
{
  public class StarFileClient : IStarFileClient
  {
    string _starsFilePath = "";
    private string getAssemblyDirectory()
    {
      string codeBase = Assembly.GetExecutingAssembly().Location;
      return Path.GetDirectoryName(codeBase);
    }

    public StarFileClient()
    {
      _starsFilePath = Path.Join(getAssemblyDirectory(), "/data/stars.csv");
      if (!File.Exists(_starsFilePath))
      {
        throw new Exception($"Could not find '{_starsFilePath}'");
      }
    }


    // This method exists to assist testing
    // notice that it is not part of the IStarFileService interface
    public void EmptyFile() => File.WriteAllText(_starsFilePath, string.Empty);


    /// Returns the content of the file as an array of strings
    /// Each string is in the format "{userid};{number of stars}"
    private async Task<string[]> getFileContent() => await File.ReadAllLinesAsync(_starsFilePath);

    /// Writes the array of strings to the file
    /// Completely replases the content of the file
    private async Task writeLinesToFile(string[] lines) => await File.WriteAllLinesAsync(_starsFilePath, lines);

    /// Returns an array for a line.
    /// turns "143,3" into ["143", "3"]
    private string[] getLineData(string line) => line.Split(',');
    /// Get the hero id from a line
    private int getHeroId(string line) => int.Parse(getLineData(line)[0]);
    ///Get the star count for a line
    private int getHeroStars(string line) => int.Parse(getLineData(line)[1]);
    // returns true is the hero id matches the hero id position of the line
    /// isHeroLine("143,3", 143) => true
    /// isHeroLine("143,3", 142) => false
    private bool isHeroLine(string line, int heroId) => getHeroId(line) == heroId;
    public async Task<int> AddStarsForHero(int heroId, int stars)
    {
      var updatedLine = $"{heroId},{stars}";

      // check if user has stars in file
      if (await GetStarsForHero(heroId) == -1)
      {
        await File.AppendAllTextAsync(_starsFilePath, updatedLine + Environment.NewLine);
        return stars;
      }

      // we need to update the file
      string[] lines = await getFileContent();

      // is the file empty?
      if (lines.Length == 0)
      {
        await writeLinesToFile(new string[] { updatedLine });
        return stars;
      }

      // Update a non-empty file
      for (int i = 0; i < lines.Length; i++)
      {
        if (isHeroLine(lines[i], heroId))
        {
          lines[i] = updatedLine;
          break;
        }
      }

      await writeLinesToFile(lines);
      return stars;
    }

    public async Task<int> GetStarsForHero(int heroId)
    {

      string[] lines = await getFileContent();

      foreach (string line in lines)
      {
        if (!string.IsNullOrWhiteSpace(line) && isHeroLine(line, heroId))
        {
          return getHeroStars(line);
        }
      }
      return -1;
    }
  }
}
