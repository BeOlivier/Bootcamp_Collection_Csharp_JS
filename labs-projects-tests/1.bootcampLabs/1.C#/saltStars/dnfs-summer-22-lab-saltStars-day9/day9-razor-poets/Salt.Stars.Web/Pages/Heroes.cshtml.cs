using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Salt.Stars.Web.Models;
using Salt.Stars.Web.Services;

namespace Salt.Stars.Web.Pages
{
  public class HeroesPage : PageModel
  {
    private readonly IHeroAPIClient _heroAPIService;

    public HeroesPage(IHeroAPIClient heroAPIService) => _heroAPIService = heroAPIService;

    [BindProperty]
    public HeroesResponse HeroesResponse { get; set; }

    [BindProperty]
    public string ErrorMessage { get; set; }

    public async Task<IActionResult> OnGetAsync()
    {
      try
      {
        HeroesResponse = await _heroAPIService.GetHeroes();
      }
      catch (System.Exception ex)
      {
        ErrorMessage = $"Could not show heroes ({ex.Message})";
      }
      return Page();
    }
  }
}
