using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Salt.Stars.API.Models;

namespace Salt.Stars.API.Services
{
  public class SwApiClient : ISwApiClient
  {
    private static Task<Stream> getHttpStreamTask(string url)
    {
      var client = new HttpClient();
      client.DefaultRequestHeaders.Accept.Clear();
      client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
      return client.GetStreamAsync(url);
    }
    public async Task<HeroListResponse> getHerosFromSwapi()
    {
      var url = $"https://swapi.py4e.com/api/people/";

      return await JsonSerializer.DeserializeAsync<HeroListResponse>(await getHttpStreamTask(url));
    }

    public async Task<Hero> getHeroFromSwapi(int id)
    {
      var url = $"https://swapi.py4e.com/api/people/{id}";

      return await JsonSerializer.DeserializeAsync<Hero>(await getHttpStreamTask(url));
    }

    public async Task<Planet> getPlanetFromSwapi(int planetId)
    {
      var url = $"https://swapi.py4e.com/api/planets/{planetId}";

      return await JsonSerializer.DeserializeAsync<Planet>(await getHttpStreamTask(url));
    }
  }
}
