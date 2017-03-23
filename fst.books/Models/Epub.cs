using Newtonsoft.Json;

namespace fst.books.Models
{
    public class Epub
    {
        [JsonProperty(PropertyName = "isAvailable")]
        public bool isAvailable { get; set; }
    }
}
