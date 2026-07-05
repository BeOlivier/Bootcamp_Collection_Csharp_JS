using System.Threading.Tasks;
using Salt.Stars.Web.Models;

namespace Salt.Stars.Web.Services
{
  public interface IHeroAPIClient
  {
    // Task<HeroesResponse> getGreeting(string Id);
    Task<HeroResponse> GetHero(int id);
    Task<HeroesResponse> GetHeroes();


  }
}
