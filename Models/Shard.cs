using System.Text.Json.Serialization;

namespace lastic_view.Models {
    public class Shard {
        [JsonPropertyName("index")]
        public string IndexName { get; set; }

        [JsonPropertyName("shard")]
        public string ShardNumber { get; set; }

        [JsonPropertyName("prirep")]
        public string PrimaryOrReploca { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("docs")]
        public string DocumentsCount { get; set; }

        [JsonPropertyName("store")]
        public string StoreSize { get; set; }

        [JsonPropertyName("ip")]
        public string Ip { get; set; }

        [JsonPropertyName("node")]
        public string Node { get; set; }
        
        public double IntSize
        {
            get
            {
                if (this.StoreSize.Contains("kb"))
                {
                    return double.Parse(this.StoreSize.Replace("kb", "")) * 1024;
                }
                if (this.StoreSize.Contains("mb"))
                {
                    return double.Parse(this.StoreSize.Replace("mb", "")) * 1024 * 1024;
                }
                if (this.StoreSize.Contains("gb"))
                {
                    return double.Parse(this.StoreSize.Replace("gb", "")) * 1024 * 1024 * 1024;
                }
                if (this.StoreSize.Contains("tb"))
                {
                    return double.Parse(this.StoreSize.Replace("tb", "")) * 1024 * 1024 * 1024 * 1024;
                }
                return double.Parse(this.StoreSize.Replace("b", ""));
            }
        }

        public Shard(string indexName, string shardNumber, string primaryOrReploca, string state, string documentsCount, string storeSize, string ip, string node)
        {
            IndexName = indexName;
            ShardNumber = shardNumber;
            PrimaryOrReploca = primaryOrReploca;
            State = state;
            DocumentsCount = documentsCount;
            StoreSize = storeSize;
            Ip = ip;
            Node = node;
        }
    }
}
