using Newtonsoft.Json;

namespace fst.books.Models
{
    public class Item
    {
        [JsonProperty(PropertyName = "volumeInfo")]
        public VolumeInfo volumeInfo { get; set; }

        [JsonProperty(PropertyName = "accessInfo")]
        public AccessInfo accessInfo { get; set; }
    }
}