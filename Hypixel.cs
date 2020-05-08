using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuickType;

namespace HypixelSkybot
{
    public static class Hypixel
    {
        private const string ApiLink = "https://api.hypixel.net";
        private const string ApiKey = "a106c7f4-555a-4ddc-bdc4-7875ab6e023b";
        private const string ProfileId = "b99305ae64c24754a8328d09fad3c83b";
        public static Return SkyblockProfile()
        {
            var str = CallMethod("skyblock/profile", "profile", ProfileId);
            var profile = JsonConvert.DeserializeObject<Return>(str);
            return profile;
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