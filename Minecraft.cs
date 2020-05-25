using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

using System.Globalization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HypixelSkybot
{
    public static class Minecraft
    {
        private const string ApiLink = "https://api.mojang.com";
        
        public static JArray UuidToUsername(string uuid)
        {
            return JArray.Parse(CallMethod("user", "profiles", uuid, "names"));
        }
        
        public static JObject UsernameToUuid(string username)
        {
            return JObject.Parse(CallMethod("users", "profiles", "minecraft", username));
        }
        
        private static string CallMethod(params string[] path)
        {
            var sb = new StringBuilder(ApiLink);
            foreach (var s in path)
            {
                sb.Append("/");
                sb.Append(s);
            }
            var link = sb.ToString();
            var req = WebRequest.CreateHttp(link);

            using (var stream = new StreamReader(req.GetResponse().GetResponseStream()))
            {
                return stream.ReadToEnd();
            }
        }
    }
}