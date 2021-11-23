using System.Text.Json.Serialization;

namespace lastic_view.Models {
    public class Index {
        [JsonPropertyName("health")]
        public string Health { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("index")]
        public string IndexName { get; set; }

        [JsonPropertyName("uuid")]
        public string UuId { get; set; }

        [JsonPropertyName("pri")]
        public string Primary { get; set; }

        [JsonPropertyName("rep")]
        public string Replicas { get; set; }

        [JsonPropertyName("docs.count")]
        public string DocumentCount { get; set; }

        [JsonPropertyName("docs.deleted")]
        public string DocumentDeleted { get; set; }

        [JsonPropertyName("store.size")]
        public string StoreSize { get; set; }

        [JsonPropertyName("pri.store.size")]
        public string PrimaryStoreSize { get; set; }

        public Index(string health, string status, string indexName, string uuId, string primary, string replicas, string documentCount, string documentDeleted, string storeSize, string primaryStoreSize)
        {
            Health = health;
            Status = status;
            IndexName = indexName;
            UuId = uuId;
            Primary = primary;
            Replicas = replicas;
            DocumentCount = documentCount;
            DocumentDeleted = documentDeleted;
            StoreSize = storeSize;
            PrimaryStoreSize = primaryStoreSize;
        }
    }
}
