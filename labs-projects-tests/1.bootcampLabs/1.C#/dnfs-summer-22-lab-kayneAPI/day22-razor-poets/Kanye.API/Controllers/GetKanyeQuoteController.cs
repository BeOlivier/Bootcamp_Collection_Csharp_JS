using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanye.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Kanye.API.Controllers
{
    [ApiController]
    [Route("/api/quote/")]

    public class GetKanyeQuoteController : ControllerBase
    {
        
        private IKanyeClient _kanyeClient;

        public GetKanyeQuoteController(IKanyeClient kanyeClient)
        {
            _kanyeClient = kanyeClient;
        }
        
        [HttpGet]
        public async Task<ActionResult<QuoteResponse>> GetKanyeQuoteAsync()
        {
            var kanyeQuote = await _kanyeClient.GetQuoteFromApi();
            return new QuoteResponse(DateTime.Now, kanyeQuote, Guid.NewGuid());
        }

        [HttpPost("comment")]
        public async Task<KanyeQuotePostResponse> AddComment()
        {
            var response = await _kanyeClient.AddCommentToApi();
            return new KanyeQuotePostResponse()
            {
                ResponseAt = DateTime.Now,
                QuoteId = response.QuoteId
            };

        }

    }    
}
