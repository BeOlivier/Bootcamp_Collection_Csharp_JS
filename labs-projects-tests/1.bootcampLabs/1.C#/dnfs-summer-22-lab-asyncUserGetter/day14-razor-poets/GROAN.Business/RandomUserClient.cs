using System.Net.Http;
// using DataResponse;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System;
using Microsoft.AspNetCore.Mvc;

namespace GROAN.Business
{
  public class RandomUserClient
  {
	// public //{ BaseAddress = new System.Uri(@"https://randomuser.me/api/")};
//     public async Task<HeroListResponse> getHerosFromSwapi() => 
//       await _client.GetFromJsonAsync<HeroListResponse>("people");
	// [HttpGet]
	public async Task<DataListResponse> GetResponses()
	{
		var _client = new HttpClient();
		string url = @"https://randomuser.me/api/?results=50";
		_client.DefaultRequestHeaders.Accept.Clear();
		_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		// var response =  await _client.GetStreamAsync(url);
		// var response = await _client.GetStreamAsync(@"?
		// results=50&inc=name,location,phone,nat");
		var response =  await _client.GetFromJsonAsync<DataListResponse>(url);
		Console.WriteLine("test4");
		

		return response;
		// var dataResponsesTask = _client.GetStreamAsync(@"https://randomuser.me/api/?results=50&inc=name,location,phone,nat");
		// return await JsonSerializer.DeserializeAsync<DataListResponse>(await dataResponsesTask);
	}
// 
    // public async Task<DataListResponse> GetResponses() => 
    //   await _client.GetFromJsonAsync<DataListResponse>(_client.BaseAddress);
// ​
//     public async Task<Planet> getPlanetFromSwapi(int id) =>
//       await _client.GetFromJsonAsync<Planet>($"planets/{id}");
  }
}
