using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Salt.Stars.Web.Models;
using Salt.Stars.Web.Services;

namespace Salt.Stars.Web.Pages
{
  public class HeroPage : PageModel
  {
    private readonly IHeroAPIClient _heroAPIClient;

    public HeroPage(IHeroAPIClient heroAPIClient) => _heroAPIClient = heroAPIClient;

    [BindProperty]
    public HeroResponse HeroResponse { get; set; }

    [BindProperty]
    public string ErrorMessage { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
      HeroResponse = null;
      try
      {
        HeroResponse = await _heroAPIClient.GetHero(id);
      }
      catch (System.Exception ex)
      {
        ErrorMessage = $"Could not show hero ({ex.Message})";
      }
      return Page();
    }

    public Task<IActionResult> OnPostAsync(int id)
    {
      throw new NotImplementedException();
    }
  }
}
