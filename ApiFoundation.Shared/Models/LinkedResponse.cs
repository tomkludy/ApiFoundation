using System.Collections.Generic;
using Newtonsoft.Json;

namespace ApiFoundation.Shared.Models
{
    public class LinkedResponse
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "_links")]
        public virtual IList<Link> Links { get; set; }
    }

    public class Link
    {
        public Link() {}
        public Link Duplicate()
        {
            return new Link
                {
                    Name = Name,
                    Href = Href,
                    Method = Method,
                };
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Href { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Method { get; set; }
    }
}