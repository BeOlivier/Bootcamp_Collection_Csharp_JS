using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Salt.Stars.API.Models;
using Salt.Stars.API.Services;

namespace Salt.Stars.API.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class PlanetsController : ControllerBase
    { 
      private readonly ISwApiClient _swApiClient;

      public PlanetsController(ISwApiClient swApiClient)
      {
        _swApiClient = swApiClient;
      }
        [HttpGet("{planetId}")]
        public async Task<ActionResult<PlanetResponse>> GetPlanetAsync(int planetId)
        {
          try
          {
            var planet = await _swApiClient.getPlanetFromSwapi(planetId);
        
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