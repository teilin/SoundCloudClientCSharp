using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using SoundCloudClient.Models;

namespace SoundCloudClient
{
    public class SoundCloudUsers
    {
        private const string BaseUrl = "http://api.soundcloud.com";

        private readonly SoundCloudAccess _access;

        public SoundCloudUsers(SoundCloudAccess access)
        {
            _access = access;
        }

        public async Task<SoundCloudUser> GetUser(int userid)
        {
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);

                var response = await client.GetAsync($"/users/{userid}?client_id={_access.ClientId}");

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<SoundCloudUser>(responseString);
                }

                throw new InvalidOperationException();
            }
        }
    }
}
