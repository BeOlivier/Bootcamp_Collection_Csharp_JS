using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Salt.Stars.Web.Models;

namespace Salt.Stars.Web.Services
{
  public class HeroAPIClient : IHeroAPIClient
  {
    private IConfiguration _configuration;

    public HeroAPIClient(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    public async Task<HeroResponse> GetHero(int id)
    {
      var client = getClient();
      var url = $"{createHeroesUrl()}{id}";

      var heroTask = client.GetStreamAsync(url);
      // var jsonTask = client.GetStringAsync(url);
      // Console.WriteLine(await jsonTask);

      return await JsonSerializer.DeserializeAsync<HeroResponse>(await heroTask);
    }

    public async Task<HeroesResponse> GetHeroes()
    {
      var client = getClient();
      var url = createHeroesUrl();

      var heroesTask = client.GetStreamAsync(url);

      return await JsonSerializer.DeserializeAsync<HeroesResponse>(await heroesTask);
    }

    public async Task<StarUpdateResponse> UpdateStars(int id, int numberOfStars)
    {
      var client = getClient();
      var url = $"{createHeroesUrl()}{id}";

      var request = new StarUpdateRequest
      {
        NewStarRating = numberOfStars
      };
      var json = JsonSerializer.Serialize<StarUpdateRequest>(request);
      var body = new StringContent(json, Encoding.UTF8, "application/json");
      var starUpdateTask = await client.PatchAsync(url, body);

      var stream = await starUpdateTask.Content.ReadAsStreamAsync();
      return await JsonSerializer.DeserializeAsync<StarUpdateResponse>(stream);
    }

    private string createHeroesUrl()
    {
      var baseUrlForApi = _configuration["ApiBaseUrl"];
      return $"{baseUrlForApi}/heroes/";
    }

    private HttpClient getClient()
    {
      var client = new HttpClient();
      client.DefaultRequestHeaders.Accept.Clear();
      client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
      return client;
    }
  }
}
