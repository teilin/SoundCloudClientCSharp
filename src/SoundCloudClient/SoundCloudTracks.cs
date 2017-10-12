using System;
using Newtonsoft.Json;
using SoundCloudClient.Models;

namespace SoundCloudClient
{
    public class SoundCloudTracks
    {
        private readonly SoundCloudAccess _access;

        public SoundCloudTracks(SoundCloudAccess access)
        {
            _access = access;
        }
    }
}
