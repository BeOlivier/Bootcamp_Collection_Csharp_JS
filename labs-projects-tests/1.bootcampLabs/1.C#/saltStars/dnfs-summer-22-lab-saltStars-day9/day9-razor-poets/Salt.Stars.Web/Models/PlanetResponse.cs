using System;
using System.Text.Json.Serialization;

namespace Salt.Stars.Web.Models
{
  public class PlanetResponse
  {
    [JsonPropertyName("planet")]
    public Planet Planet { get; set; }

    [JsonPropertyName("requestedAt")]
    public DateTime RequestedAt { get; set; }
  }
}