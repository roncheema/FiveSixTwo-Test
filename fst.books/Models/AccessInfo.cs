using Newtonsoft.Json;

namespace fst.books.Models
{
    public class AccessInfo
    {
        [JsonProperty(PropertyName = "epub")]
        public Epub epub { get; set; }
    }
}
