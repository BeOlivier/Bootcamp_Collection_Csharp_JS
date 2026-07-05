using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Salt.Stars.Web.Models
{
  public class HeroesResponse
  {
	[JsonPropertyName("results")]
	public List<Hero> Heroes { get; set; }
	[JsonPropertyName("count")]
	public int Count {get; set;}
	[JsonPropertyName("pageSize")]
	public int PageSize {get; set;}
  }
}