using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HypixelSkybot
{
    public static class Hypixel
    {
        private const string ApiLink = "https://api.hypixel.net";
        public static string ApiKey;
        
        public static JObject SkyblockProfile(string profileId)
        {
            return CallMethod("skyblock/profile", "profile", profileId);
        }

        public static JObject Player(string uuid)
        {
            return CallMethod("player", "uuid", uuid);
        }
        
        private static JObject CallMethod(string function, string paramName = "", string paramValue = "")
        {
            var param = paramName == "" ? "" : $"&{paramName}={paramValue}";
            var link = $"{ApiLink}/{function}?key={ApiKey}{param}";
            var req = WebRequest.CreateHttp(link);

            using (var stream = new StreamReader(req.GetResponse().GetResponseStream()))
            {
                var response = stream.ReadToEnd();
                return JObject.Parse(response);;
            }
        }
    }
}