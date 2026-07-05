using System;

namespace Salt.Stars.API.Models
{
  public class PlanetResponse
  {
    public Planet Planet { get; set; }
    public DateTime RequestedAt { get; set; }
  }
}
