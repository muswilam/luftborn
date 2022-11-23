using Newtonsoft.Json;

namespace Web.Models
{
    public class RemoveUserModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}