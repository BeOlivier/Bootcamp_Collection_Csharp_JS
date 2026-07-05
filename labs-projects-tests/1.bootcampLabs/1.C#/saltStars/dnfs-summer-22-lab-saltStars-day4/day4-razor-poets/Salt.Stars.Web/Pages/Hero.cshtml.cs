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

    public HeroPage(IHeroAPIClient heroAPIClient)
    {
        _heroAPIClient = heroAPIClient;
    }

    // [BindProperty]
    public HeroResponse HeroResponse { get; set; }

    // [BindProperty]
    public string ErrorMessage { get; set; }

    // [BindProperty(SupportsGet = true)]
    // public string Id { get; set; }
    public async Task<IActionResult> OnGetAsync(int Id)
    {
        try
        {

            HeroResponse = await _heroAPIClient.GetHero(Id);
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
//     private readonly IHeroAPIClient _HeroAPIClient;
//     public IndexPage(IGreetingAPIClient greetingAPIClient) => _greetingAPIClient = greetingAPIClient;

//     [BindProperty]
//     public GreetingResponse Greeting { get; set; }

//     [BindProperty]
//     public string ErrorMessage { get; set; }

//     [BindProperty(SupportsGet = true)]
//     public string DeveloperName { get; set; }

//     public async Task<IActionResult> OnGetAsync()
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