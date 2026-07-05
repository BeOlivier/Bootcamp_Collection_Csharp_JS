using System;

namespace Salt.Stars.Greeter
{

  public class GreeterService : IGreeter
  {
    private GreetingFileReader _reader;
    // This helper function returns a random string from an array of strings
    private string getRandomGreetingString(string[] greetings)
    {
      var randIndex = new Random().Next(greetings.Length);
      return greetings[randIndex];
    }

    public GreeterService(GreetingFileReader reader)
    {
      _reader = reader;
      // Now try to get the data from the directory...
      // Yipiie-kay aaaaamohahahahaaaaa
      // Hans G
      // var reader = //
      // string result = getRandomGreetingString();
      //    IEnumerable<string> GetPoliteGreetings();
    //string[] GetImpoliteGreetings();
    }

    public GreeterService()
    {

    }

    public string greetNicely(string name){
      var randomString = getRandomGreetingString();
      

    }// => getRandomGreetingString();//$"Hello {name}! Nice to meet you.";

    public string greetImpolitely(string name) => //$"{name}?! Go suck a Pickle!";

    public string greet(string name, DateTime dt) =>
      dt.Second % 2 == 0 ?
        greetNicely(name) :
        greetImpolitely(name);
  }
}
