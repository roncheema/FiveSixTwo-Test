using Newtonsoft.Json;
using System.Collections.Generic;

namespace fst.books.Models
{
    public class RootObject
    {
        [JsonProperty(PropertyName = "kind")]
        public string kind { get; set; }

        [JsonProperty(PropertyName = "totalItems")]
        public int totalItems { get; set; }

        [JsonProperty(PropertyName = "items")]
        public IList<Item> items { get; set; }
    }
}