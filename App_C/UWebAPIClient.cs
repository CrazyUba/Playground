using Newtonsoft.Json;
using System;

using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace App_C
{

    public class UWebAPIClient
    {

        static HttpClient client = new HttpClient();
        public static void Init(string ip, string appName)
        {
            client.BaseAddress = new Uri($"http://{ip}/{appName}/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

    
        public static async Task<T> GetObjectAsync<T>()
        {
           
            T @object = default(T);

            HttpResponseMessage response = await client.GetAsync($"api/{typeof(T).Name}");

            if (response.IsSuccessStatusCode)
            {
                string value = await response.Content.ReadAsStringAsync();
                @object = JsonConvert.DeserializeObject<T>(value);
            }

            
            return @object;
        }

    }
}
