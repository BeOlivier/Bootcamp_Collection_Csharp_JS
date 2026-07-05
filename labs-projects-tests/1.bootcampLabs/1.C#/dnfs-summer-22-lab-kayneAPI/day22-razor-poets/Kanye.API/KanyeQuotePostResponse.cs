using System;
using System.Text.Json.Serialization;

namespace Kanye.API
{
    public class KanyeQuotePostResponse
    {
        public DateTime ResponseAt { get; set; }
        [JsonPropertyName("id")]
        public int QuoteId { get; set; }
    }
}