using System.Net.Http;
using Newtonsoft.Json;

namespace School.Ping
{
    public static class JsonBody
    {
        public static T Body<T>(this HttpResponseMessage response)
        {
            var body = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(body);
        }
    }
}