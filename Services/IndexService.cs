using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace lastic_view.Services {
    public class IndexService {
        private static readonly HttpClient client = new HttpClient();
        private readonly ClusterNameUrlService _urlService;
        public IndexService(ClusterNameUrlService urlService)
        {
            _urlService = urlService;
        }

        public async Task<Models.Index[]> GetIndexes()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            try
            {
                var stringTask = await client.GetStringAsync(_urlService.currentClusterUrl + "/_cat/indices?format=json");
                var jsonList = JsonSerializer.Deserialize<Models.Index[]>(stringTask);
                return jsonList;
            }
            catch (Exception)
            {
                return Array.Empty<Models.Index>();
            }
        }
    }
}
