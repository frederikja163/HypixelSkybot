using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HypixelSkybot
{
    public static class Minecraft
    {
        public static User[] UuidToUsername(string uuid)
        {
            var link = $"https://api.mojang.com/user/profiles/{uuid}/names";
            var req = WebRequest.CreateHttp(link);

            using (var stream = new StreamReader(req.GetResponse().GetResponseStream()))
            {
                var response = stream.ReadToEnd();
                var profile = JsonConvert.DeserializeObject<User[]>(response);
                return profile;
            }
        }

        public class User
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("changedToAt", NullValueHandling = NullValueHandling.Ignore)]
            public long? ChangedToAt { get; set; }
        }
    }
}