using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Salt.Stars.Web.Models;
using Salt.Stars.Web.Services;

namespace Salt.Stars.Web.Pages
{
  public class HeroPage : PageModel
  {
    private readonly IHeroAPIClient _heroAPIService;

    public HeroPage(IHeroAPIClient heroAPIService) => _heroAPIService = heroAPIService;

    [BindProperty]
    public HeroResponse HeroResponse { get; set; }

    [BindProperty]
    public string ErrorMessage { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
      HeroResponse = null;
      try
      {
        HeroResponse = await _heroAPIService.GetHero(id);
      }
      catch (System.Exception ex)
      {
        ErrorMessage = $"Could not show hero ({ex.Message})";
      }
      return Page();
    }

    public async Task<IActionResult> OnPostAsync(int id)
    {
      try
      {
        var response = await _heroAPIService.UpdateStars(id, HeroResponse.Hero.StarRating);
      }
      catch (System.Exception ex)
      {
        ErrorMessage = $"Could not update stars for hero ({ex.Message})";
      }
      return RedirectToAction("OnGetAsync", new { id = id });
    }
  }
}
