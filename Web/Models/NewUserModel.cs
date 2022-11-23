using Newtonsoft.Json;

namespace Web.Models
{
    public class NewUserModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("genderId")]
        public int GenderId { get; set; }
    }
}