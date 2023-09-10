using System.Text.Json.Serialization;

namespace BlazorAppWebAssembly.Models
{
    public class ZipCodePrimaryModel
    {
        [JsonPropertyName("post code")]
        public string? post_code { get; set; }
        public string? country { get; set; }
        [JsonPropertyName("country abrebiation")]
        public string? country_abrebiation { get; set; }

        public List<ListOfPlacesModel>? places { get; set; }
    }
}

