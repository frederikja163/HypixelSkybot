using Newtonsoft.Json.Linq;

namespace HypixelSkybot.Extensions
{
    public static class JTokenExtension
    {
        public static string Name(this JToken obj)
        {
            return obj.Path.Substring(obj.Path.LastIndexOf('.') + 1);
        }
    }
}