using Newtonsoft.Json;

namespace fst.books.Models
{
    public class VolumeInfo
    {
        [JsonProperty(PropertyName = "title")]
        public string title { get; set; }

        [JsonProperty(PropertyName = "pageCount")]
        public int pageCount { get; set; }

        [JsonProperty(PropertyName = "averageRating")]
        public float averageRating { get; set; }

    }
}
