using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Salt.Stars.Web.Models;
using Salt.Stars.Web.Services;

namespace Salt.Stars.Web.Pages
{
  public class PlanetPage : PageModel
  {
    private readonly IPlanetAPIClient _planetAPIService;

    public PlanetPage(IPlanetAPIClient planetAPIService)
    {
      _planetAPIService = planetAPIService;
    }

    [BindProperty]
    public PlanetResponse PlanetResponse { get; set; }

    [BindProperty]
    public string ErrorMessage { get; set; }
    public async Task<IActionResult> OnGetAsync(int id)
    {
      PlanetResponse = null;
      try
      {
        PlanetResponse = await _planetAPIService.GetPlanet(id);
      }
      catch (System.Exception ex)
      {
        ErrorMessage = $"Could not show planet ({ex.Message})";
      }
      return Page();
    }
  }
}
