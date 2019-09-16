using System;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstaSharp
{
    public class Parser
    {
        /// <summary>
        /// Gets user's data as JObject
        /// </summary>
        /// <param name="Username">Username of the user to retrieve</param>
        /// <returns>JObject</returns>
        public static JObject ParseUserData(string Username)
        {
            string APIURL = "https://www.instagram.com/" + Username + "/?__a=1";

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(APIURL).Result)
                {
                    if(response.StatusCode.ToString() == "NotFound") throw new Exception($"User[{Username}] Not Found");

                    using (HttpContent content = response.Content)
                    {
                        var json = content.ReadAsStringAsync().Result;
                        return JObject.Parse(json);
                    }
                }
            }
        }
    }
}
