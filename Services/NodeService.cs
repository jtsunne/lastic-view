using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using lastic_view.Models;

namespace lastic_view.Services {
    public class NodeService {
        private static readonly HttpClient client = new HttpClient();
        private readonly ClusterNameUrlService _urlService;
        public NodeService(ClusterNameUrlService urlService)
        {
            _urlService = urlService;
        }

        public async Task<Node[]> GetNodes()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            try
            {
                var stringTask = await client.GetStringAsync( _urlService.currentClusterUrl + "/_cat/nodes?format=json");
                var jsonList = JsonSerializer.Deserialize<Node[]>(stringTask);
                return jsonList;
            }
            catch (Exception)
            {
                return Array.Empty<Node>();
            }
        }
    }
}
