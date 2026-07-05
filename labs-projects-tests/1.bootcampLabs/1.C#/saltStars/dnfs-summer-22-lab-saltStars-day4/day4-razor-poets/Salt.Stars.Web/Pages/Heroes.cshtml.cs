using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Salt.Stars.Web.Models;
using Salt.Stars.Web.Services;

namespace Salt.Stars.Web.Pages
{
  public class HeroesPage : PageModel
  {
    private readonly IHeroAPIClient _heroAPIClient;


    // [BindProperty]
    public HeroesResponse HeroesResponse { get; set; }

    // [BindProperty]
    public string ErrorMessage { get; set; }
    public HeroesPage(IHeroAPIClient heroAPIClient)
    {
        _heroAPIClient = heroAPIClient;
    }

    // [BindProperty(SupportsGet = true)]
    // public string Id { get; set; }
      public async Task<IActionResult> OnGetAsync()
    {
        try
        {

            HeroesResponse = await _heroAPIClient.GetHeroes();
        }
        catch (System.Exception ex)
        {
            ErrorMessage = $"Something went terrible wrong ({ex.Message})";
        }

      return Page();
    }
      
//     private readonly IGreetingAPIClient _greetingAPIClient; used
//     public IndexPage(IGreetingAPIClient greetingAPIClient) => _greetingAPIClient = greetingAPIClient;

//     

//     public async Task<IActionResult> OnGetAsync() used
//     {
//       try
//       {
//         if (!string.IsNullOrEmpty(DeveloperName))
//         {
//           Greeting = await _greetingAPIClient.getGreeting(DeveloperName);
//         }
//       }
//       catch (System.Exception ex)
//       {
//         ErrorMessage = $"Something went terrible wrong ({ex.Message})";
//       }

//       return Page();
//     }
  }
}