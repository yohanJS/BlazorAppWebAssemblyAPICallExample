using System.Text.Json.Serialization;

namespace BlazorAppWebAssembly.Models
{
    public class ListOfPlacesModel
    {
        [JsonPropertyName("place name")]
        public string? place_name { get; set; }
        public string? longitude { get; set; }
        public string? state { get; set; }
        [JsonPropertyName("state abbreviation")]
        public string? state_abbreviation { get; set; }
        public string? latitude { get; set; }
    }
}
