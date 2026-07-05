using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Salt.Stars.API.Models;
using Salt.Stars.API.Services;

namespace Salt.Stars.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public partial class PlanetsController : ControllerBase
  {
    private readonly ISwApiClient _swApiClient;

    public PlanetsController(ISwApiClient swApiClient)
    {
      _swApiClient = swApiClient;
    }

    [HttpGet]
    public async Task<ActionResult<PlanetListResponse>> GetPlanetListAsync()
    {
      try
      {
        var planetListResponse = await _swApiClient.getPlanetsFromSwapi();
        planetListResponse.PageSize = planetListResponse.Planets.Count;
        planetListResponse.CurrentPage = 1;
        planetListResponse.RequestedAt = DateTime.Now;

        var i = 1;
        var utils = new ModelUtilities();
        foreach(var planet in planetListResponse.Planets)
        {
          planet.Id = i;
          utils.IncrementI(ref i);
        }
    
        return planetListResponse;
    
      }
      catch (System.Exception ex)
      {
        return NotFound(ex.ToString());
      }
    }
    

    [HttpGet("{id}")]
    public async Task<ActionResult<PlanetResponse>> GetPlanetAsync(int id)
    {
      try
      {
        var planet = await _swApiClient.getPlanetFromSwapi(id);
        planet.Id = id;
        
        return new PlanetResponse
        {
          Planet = planet
        };
      }
      catch (System.Exception ex)
      {
        return NotFound(ex.ToString());
      }
    }
  }
}

