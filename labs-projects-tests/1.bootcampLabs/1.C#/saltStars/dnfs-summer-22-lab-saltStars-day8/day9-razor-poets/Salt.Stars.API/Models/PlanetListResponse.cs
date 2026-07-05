using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Salt.Stars.API.Models
{
    public class PlanetListResponse
    {
        [JsonPropertyName("count")]
        public short Count { get; set; }
        [JsonPropertyName("results")]
        public IList<Planet> Planets { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public DateTime RequestedAt { get; set; }

    }
}