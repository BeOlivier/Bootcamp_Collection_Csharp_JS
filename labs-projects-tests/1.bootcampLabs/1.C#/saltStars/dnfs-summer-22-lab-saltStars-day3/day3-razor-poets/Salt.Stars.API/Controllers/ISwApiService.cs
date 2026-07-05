using System.Threading.Tasks;
using Salt.Stars.API.Models;

namespace Salt.Stars.API.Controllers
{
  public interface ISwApiService
  {
    Task<HeroListResponse> getHerosFromSwapi();
    Task<Hero> getHeroFromSwapi(short id);
  }
}
