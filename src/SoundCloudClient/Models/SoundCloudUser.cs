using System;
using Newtonsoft.Json;

namespace SoundCloudClient.Models
{
    public class SoundCloudUser
    {
        [JsonProperty("id")]
        public int UserId { get; set; }
        [JsonProperty("permalink")]
        public string Permalink { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("uri")]
        public string Url { get; set; }
        [JsonProperty("permalink_url")]
        public string PermalinkUrl { get; set; }
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("full_name")]
        public string FullName { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("discogs-name")]
        public string DiscogsName { get; set; }
        [JsonProperty("myspace-name")]
        public string MyspaceName { get; set; }
        [JsonProperty("website")]
        public string Website { get; set; }
        [JsonProperty("website-title")]
        public string WebsiteTitle { get; set; }
        [JsonProperty("online")]
        public bool Online { get; set; }
        [JsonProperty("track_count")]
        public int TrackCount { get; set; }
        [JsonProperty("playlist_count")]
        public int PlaylistCount { get; set; }
        [JsonProperty("followers_count")]
        public int FollowersCount { get; set; }
        [JsonProperty("followings_count")]
        public int FollowingCount { get; set; }
        [JsonProperty("public_favorites_count")]
        public int PublicFavoritesCount { get; set; }
    }
}
