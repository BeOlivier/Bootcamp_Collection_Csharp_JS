using System.Threading.Tasks;
using Salt.Stars.Web.Models;

namespace Salt.Stars.Web.Services
{
  public interface IPlanetAPIClient
  {
    Task<PlanetResponse> GetPlanet(int id);
  }
}