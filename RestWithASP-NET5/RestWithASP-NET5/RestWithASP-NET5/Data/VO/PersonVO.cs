using RestWithASP_NET5.Hypermedia;
using RestWithASP_NET5.Hypermedia.Abstract;
using RestWithASP_NET5.Model.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RestWithASP_NET5.Data.VO
{
    public class PersonVO : ISupportsHyperMedia
    {
        [JsonPropertyName("code")]
        public long Id { get; set; }
        [JsonPropertyName("name")]
        public string FirstName { get; set; }     
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        [JsonIgnore]
        public string Address { get; set; }
        public string Gender { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
