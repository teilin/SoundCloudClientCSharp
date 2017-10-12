using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using SoundCloudClient.Models;

namespace SoundCloudClient
{
    public class SoundCloudClient
    {
        private readonly SoundCloudAuth _auth;

        private SoundCloudAccess _access;
        private SoundCloudUsers _users;
        private SoundCloudTracks _tracks;

        public SoundCloudClient(SoundCloudAuth auth)
        {
            if (auth == null) throw new ArgumentNullException(nameof(auth));

            _auth = auth;
        }

        public async Task<SoundCloudAccess> Auth(SoundCloudAuth auth, CancellationToken token)
        {
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.soundcloud.com");

                var authContent = new StringContent(JsonConvert.SerializeObject(auth));

                var authResponse = await client.PostAsync("/oauth2/token", authContent);

                if(authResponse.IsSuccessStatusCode)
                {
                    var returnString = await authResponse.Content.ReadAsStringAsync();
                    _access = JsonConvert.DeserializeObject<SoundCloudAccess>(returnString);

                    _access.ClientId = auth.ClientId;

                    return _access;
                }

                throw new InvalidOperationException("");
            }
        }

        public SoundCloudUsers Users => _users ?? (_users = new SoundCloudUsers(_access));

        public SoundCloudTracks Tracks => _tracks ?? (_tracks = new SoundCloudTracks(_access));
    }
}
