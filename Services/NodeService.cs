using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using lastic_view.Models;

namespace lastic_view.Services {
    public class NodeService {
        private static readonly HttpClient client = new HttpClient();
        
        public static async Task<Node[]> GetNodes(String url)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            try
            {
                var stringTask = await client.GetStringAsync(url + "/_cat/nodes?format=json");
                var jsonList = JsonSerializer.Deserialize<Node[]>(stringTask);
                // Console.Write(jsonList);
                return jsonList;
            }
            catch (Exception e)
            {
                return Array.Empty<Node>();
            }
        }
    }
}
