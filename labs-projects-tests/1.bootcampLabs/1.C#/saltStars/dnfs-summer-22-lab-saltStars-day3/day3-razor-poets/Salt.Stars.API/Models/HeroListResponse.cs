using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Salt.Stars.API.Models
{
  public class HeroListResponse
  {

    [JsonPropertyName("results")]
    public IList<Hero> Heroes { get; set; }

    // TODO: Add properties for Count, PageSize, CurrentPage
    // and add RequestedAt date that should be set in the controller when you respond back
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("next")]
    public string NextPage {get; set;}

    [JsonPropertyName("previous")]
    public string PreviousPage {get; set;}
    public int CurrentPage { 
      get{
        if (NextPage != null)
          return int.Parse(NextPage.Split("=")[NextPage.Split("=").Length - 1]);

        else
          return int.Parse(PreviousPage.Split("=")[PreviousPage.Split("=").Length - 1]) + 1;

    }}
    public int PageSize 
    {
      get{
        return Heroes.Count;
         } 
      set{}
    }

   






  }
}