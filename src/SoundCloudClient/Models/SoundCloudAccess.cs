using System;
using Newtonsoft.Json;

namespace SoundCloudClient.Models
{
    public class SoundCloudAccess
    {
        [JsonIgnore]
        public string ClientId { get; set; }
        [JsonProperty("access_token")]
		public string AccessToken { get; set; }
        [JsonProperty("scope")]
		public string Scope { get; set; }
    }
}
