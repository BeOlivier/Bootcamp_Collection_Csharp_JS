using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Salt.Stars.Web.Models;

namespace Salt.Stars.Web.Services
{
  public class PlanetAPIClient : IPlanetAPIClient
  {
    private IConfiguration _configuration;

    public PlanetAPIClient(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    public async Task<PlanetResponse> GetPlanet(int id)
    {
      var client = new HttpClient();
      client.DefaultRequestHeaders.Accept.Clear();
      client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

      var url = $"{_configuration["ApiBaseUrl"]}/planets/{id}";
      var planetTask = client.GetStreamAsync(url);
      // var jsonTask = client.GetStringAsync(url);
      // Console.WriteLine(await jsonTask);

      return await JsonSerializer.DeserializeAsync<PlanetResponse>(await planetTask);
    }
  }
}
