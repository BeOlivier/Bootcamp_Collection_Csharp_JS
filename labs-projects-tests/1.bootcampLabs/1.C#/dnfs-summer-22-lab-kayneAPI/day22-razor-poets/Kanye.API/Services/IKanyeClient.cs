using System.Threading.Tasks;


namespace Kanye.API.Services
{
  public interface IKanyeClient
  {
    Task<KanyeQuote> GetQuoteFromApi();
    Task<KanyeQuotePostResponse> AddCommentToApi();

  }
}