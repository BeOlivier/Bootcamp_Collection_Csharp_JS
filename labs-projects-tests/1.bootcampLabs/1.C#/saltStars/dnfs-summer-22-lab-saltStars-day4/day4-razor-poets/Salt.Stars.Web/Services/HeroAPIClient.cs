using System.Net.Http;
using System.Net.Http.Headers;
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

        // public Task<HeroesResponse> GetHero(int id)
        // {
        //     throw new System.NotImplementedException();
        // }

        // private string createGreetingUrl(string name)
        // {
        //   var baseUrlForApi = _configuration["ApiBaseUrl"];
        //   return $"{baseUrlForApi}/greeting?name={name}";
        // }


        private string createHeroUrl(int id)
        {
        var baseUrlForApi = _configuration["https//:localhost:5001/api/Heroes"];//https://localhost:5001/api/Heroes

        return $"https://localhost:5001/api/Heroes/{id}";
        }

        private string createHeroesUrl()
        {
        var baseUrlForApi = _configuration["https//:localhost:5001/api/Heroes"];
        return "https://localhost:5001/api/Heroes";
        }        

        public async Task<HeroResponse> GetHero(int id)
        {
          var client = new HttpClient();
          client.DefaultRequestHeaders.Accept.Clear();
          client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));

          var url = createHeroUrl(id);
          var HeroTask = client.GetStreamAsync(url);

          var heroResult = await JsonSerializer.DeserializeAsync<HeroResponse>(await HeroTask);
          return heroResult;
        }
        public async Task<HeroesResponse> GetHeroes()
        {
          var client = new HttpClient();
          client.DefaultRequestHeaders.Accept.Clear();
          client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

          var HeroTask = client.GetStreamAsync(createHeroesUrl());

          var heroesResult = await JsonSerializer.DeserializeAsync<HeroesResponse>(await HeroTask);
          return heroesResult;
        }
    }
}