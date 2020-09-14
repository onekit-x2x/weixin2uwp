using System;
using Windows.Data.Json;

namespace onekit
{
    public class JSON
    {
        public static IJsonValue parse(String json)
        {
            return JsonObject.Parse(json);
        }
        public static String stringify(IJsonValue json)
        {
            return json.ToString();
        }
    }
}

