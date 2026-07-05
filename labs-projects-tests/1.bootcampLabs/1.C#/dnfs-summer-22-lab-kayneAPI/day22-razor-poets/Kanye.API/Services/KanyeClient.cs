using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Kanye.API;

namespace Kanye.API.Services
{
    public class KanyeClient : IKanyeClient
    {
        public async Task<KanyeQuote> GetQuoteFromApi()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var url = $"https://api.kanye.rest/";
            var quoteTask = client.GetStreamAsync(url);

            return await JsonSerializer.DeserializeAsync<KanyeQuote>(await quoteTask);
        }
        public async Task<KanyeQuotePostResponse> AddCommentToApi()
        {    
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            // client.DefaultRequestHeaders.Accept.Add(
            //     new MediaTypeWithQualityHeaderValue("application/json"));
            
            var url = "https://jsonplaceholder.typicode.com/posts";

            var data = new KanyeQuotePostRequest()
            {
                UserName = "Vlad"
            };
            var json = JsonSerializer.Serialize(data);
            var body = new StringContent(json, Encoding.UTF8, "application/json");
            var quoteTask = await client.PostAsync(url, body);
            var stream = await quoteTask.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<KanyeQuotePostResponse>(stream);

        }
    }
}