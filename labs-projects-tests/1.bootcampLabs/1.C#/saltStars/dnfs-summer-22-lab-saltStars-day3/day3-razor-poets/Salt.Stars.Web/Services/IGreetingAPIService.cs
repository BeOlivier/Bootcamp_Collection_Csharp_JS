using System.Threading.Tasks;
using Salt.Stars.Web.Models;

namespace Salt.Stars.Web.Services
{
  public interface IGreetingAPIService
  {
    Task<GreetingResponse> getGreeting(string name);
  }
}
