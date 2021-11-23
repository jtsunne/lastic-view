using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace lastic_view.Services {
    public class IndexService {
        private static readonly HttpClient client = new HttpClient();
        
        public static async Task<Models.Index[]> GetIndexes(String url)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            try
            {
                var stringTask = await client.GetStringAsync(url + "/_cat/indices?format=json");
                var jsonList = JsonSerializer.Deserialize<Models.Index[]>(stringTask);
                return jsonList;
            }
            catch (Exception e)
            {
                return Array.Empty<Models.Index>();
            }
        }
    }
}
