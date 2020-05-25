using Newtonsoft.Json.Linq;

namespace HypixelSkybot.Extensions
{
    public static class JTokenExtension
    {
        public static string Name(this JToken obj)
        {
            return obj.Path.Substring(obj.Path.LastIndexOf('.') + 1);
        }

        public static T GetValue<T>(this JToken obj, params string[] path)
        {
            var tok = obj;
            foreach (var p in path)
            {
                tok = tok[p];
                if (tok == null)
                {
                    return default;
                }
            }

            return tok.Value<T>() ?? default;
        }
    }
}