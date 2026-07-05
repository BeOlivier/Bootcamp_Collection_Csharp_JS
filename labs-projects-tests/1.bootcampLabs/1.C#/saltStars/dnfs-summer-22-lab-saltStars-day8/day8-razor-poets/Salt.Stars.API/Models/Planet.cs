using System;
using System.Text.Json.Serialization;

namespace Salt.Stars.API.Models
{
    public class Planet
    {
        [JsonPropertyName("url")] public string Url { get; set; }

        [JsonPropertyName("name")] public string Name { get; set; }

        [JsonPropertyName("PlanetId")]
        public int PlanetID
        {
            get
            {
                var urlString = Url.EndsWith('/') ? Url.Remove(Url.Length - 1, 1) : Url;
                var idString = urlString.Remove(0, urlString.LastIndexOf('/') + 1);

                int id;
                bool success = int.TryParse(idString, out id);
                if (!success)
                {
                    throw new Exception($"No numeric id found in url '{Url}'");
                }

                return id;
            }

        }
    }

}