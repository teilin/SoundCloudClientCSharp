﻿using System;
using Newtonsoft.Json;

namespace SoundCloudClient.Models
{
    public class SoundCloudAuth
    {
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }
        [JsonProperty("grant_type")]
        public string GrantType { get; set; }
        [JsonProperty("code")]
        public string AuthCode { get; set; }
    }
}
