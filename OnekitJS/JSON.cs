using System;
using Windows.Data.Json;

namespace onekit
{
    public class JSON
    {
        public static IJsonValue parse(string json)
        {
            return JsonObject.Parse(json);
        }
        public static string stringify(IJsonValue json)
        {
            return json.ToString();
        }
    }
}

