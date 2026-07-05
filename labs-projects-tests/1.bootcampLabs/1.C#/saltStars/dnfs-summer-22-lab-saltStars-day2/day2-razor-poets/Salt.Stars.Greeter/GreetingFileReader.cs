using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Salt.Stars.Greeter
{
  public class GreetingFileReader : IGreetingFileReader
  {
    public string _responses {get; set;}
    private string _dataDirectory;

    // This helper-method returns the location of the current assembly
    // that is useful to find a directory next to it
    private string getAssemblyDirectory()
    {
      
      string codeBase = Assembly.GetExecutingAssembly().Location;
      return Path.GetDirectoryName(codeBase);
    }
  
/*
    foreach (string line in System.IO.File.ReadLines(@“c:\test.txt”))
{
    System.Console.WriteLine(line);
}
*/

    public IEnumerable<string> GetPoliteGreetings()
    {

      var result = new List<string>();
      foreach (string line in System.IO.File.ReadLines(_dataDirectory + "/politeGreetings.txt"))
      {
        //Console.WriteLine(line);
        result.Add(line);
      }
      // foreach (string line in result)
      // {
      //   Console.WriteLine(line);
      // }
      return result;
      // throw new NotImplementedException();
    }

    public string[] GetImpoliteGreetings()
    {

      var result = new List<string>();
      foreach (string line in System.IO.File.ReadLines(_dataDirectory + "/impoliteGreetings.txt"))
      {
        // Console.WriteLine(line);
        result.Add(line);
      }
      // foreach (string line in result)
      // {
      //   Console.WriteLine(line);
      // }

      return result.ToArray();
      // throw new NotImplementedException();
    }

    public GreetingFileReader(string directoryPath)
    {
      var hopefulDirectory = getAssemblyDirectory() + "/" + directoryPath;
      // try {
        if(!Directory.Exists(hopefulDirectory))
            {
                _dataDirectory = hopefulDirectory;
            }
        else {
          throw new Exception();
        }
      // // Console.WriteLine(_dataDirectory);
      //   } catch {
      //     // Console.WriteLine("Directory does not exist!!!");
      //     throw new Exception(); 
      //   }
      
    }
  }
}