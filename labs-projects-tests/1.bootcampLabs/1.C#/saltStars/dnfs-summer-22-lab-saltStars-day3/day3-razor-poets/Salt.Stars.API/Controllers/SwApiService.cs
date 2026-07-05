using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Salt.Stars.API.Models;

namespace Salt.Stars.API.Controllers
{
  public class SwApiService : ISwApiService
  {

    public async Task<HeroListResponse> getHerosFromSwapi()
    {
      // var client = new HttpClient();
      // client.DefaultRequestHeaders.Accept.Clear();
      // client.DefaultRequestHeaders.Accept.Add(
      //   new MediaTypeWithQualityHeaderValue("application/json")
      // );


      //   var url = "https://swapi.py4e.com/api/people/";
      //   var peopleTask = client.GetStringAsync(url);
      //   Console.WriteLine(await peopleTask);
      // // send  a request for data to the external database
      // // take the JSON response
      // // extract the different heroes (deserialize)
      // // Instantiate heroListResponse object
      	var client = new HttpClient();
		client.DefaultRequestHeaders.Accept.Clear();
		client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		var url = "https://swapi.py4e.com/api/people/";

		var getHeroes = await client.GetStreamAsync(url);
		return await JsonSerializer.DeserializeAsync<HeroListResponse>(getHeroes);
      // throw new NotImplementedException("Write code here");
      
      // return null;
    }

    public async Task<Hero> getHeroFromSwapi(short id) //this method returns a HERO
    {
      // throw new NotImplementedException("Write code here");
      Console.WriteLine("OUR MAGIC ID IS: " + id);
		var client = new HttpClient();
		client.DefaultRequestHeaders.Accept.Clear();
		client.DefaultRequestHeaders.Accept.Add(
			new MediaTypeWithQualityHeaderValue("application/json")
		);
		var url = $"https://swapi.py4e.com/api/people/{id.ToString()}";


		var getHero = await client.GetStreamAsync(url);
		return await JsonSerializer.DeserializeAsync<Hero>(getHero);
    }
  }
}
