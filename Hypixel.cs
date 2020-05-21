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
            var str = CallMethod("skyblock/profile", "profile", profileId);
            var obj = JObject.Parse(str);
            return obj;
        }

        public static JObject Stats(string uuid)
        {
            var str = CallMethod("player", "uuid", uuid);
            var obj = JObject.Parse(str);
            return obj;
        }
        
        private static string CallMethod(string function, string paramName = "", string paramValue = "")
        {
            var param = paramName == "" ? "" : $"&{paramName}={paramValue}";
            var link = $"{ApiLink}/{function}?key={ApiKey}{param}";
            var req = WebRequest.CreateHttp(link);

            using (var stream = new StreamReader(req.GetResponse().GetResponseStream()))
            {
                var response = stream.ReadToEnd();
                return response;
            }
        }
    }
}