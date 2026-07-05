using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Salt.Stars.API.Models;

namespace Salt.Stars.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public partial class HeroesController : ControllerBase
  {
    private readonly ISwApiService _swApiService;

    public HeroesController(ISwApiService swApiService)
    {
      _swApiService = swApiService;
    }

    [HttpGet]
    public async Task<ActionResult<HeroListResponse>> GetHeroListAsync()
    {
      // var heroList = await _swApiService.getHerosFromSwapi();

      // //throw new NotImplementedException("Write code here");
      // return heroList;
        HeroListResponse heroesList = null;
        try
        {
          heroesList = await _swApiService.getHerosFromSwapi();
        }
        catch (Exception)
        {
          // Console.WriteLine(ex.Message);
        }
        // if (heroesList == null)
        // 	throw new Exception();
        // else
        return heroesList;
        }

    [HttpGet("{id}")]
    public async Task<ActionResult<HeroResponse>> GetHeroAsync(short id)
    {
      // var heroResponse = new HeroResponse();
      // try{
      //   heroResponse.Hero = await _swApiService.getHeroFromSwapi(id);
      // } catch (Exception e){
      //   return heroResponse;
      // }

      // return heroResponse;
      HeroResponse heroResponse = null;
      try{
        heroResponse = new HeroResponse();
        heroResponse.Hero =  await _swApiService.getHeroFromSwapi(id);
      }
      catch (Exception) {
        heroResponse = null;
      }
      return heroResponse;
    }
  }
}
