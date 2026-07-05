using System.Text.Json.Serialization;

namespace Kanye.API
{
    public class KanyeQuote
    {
        [JsonPropertyName("quote")]
        public string Quote { get; set; }
    }
}
