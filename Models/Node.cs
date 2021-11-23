using System.Text.Json.Serialization;

namespace lastic_view.Models {
    public class Node {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("ip")]
        public string IP { get; set; }

        [JsonPropertyName("heap.percent")]
        public string HeapPercent { get; set; }

        [JsonPropertyName("ram.percent")]
        public string RamPercent { get; set; }

        [JsonPropertyName("cpu")]
        public string CPU { get; set; }

        [JsonPropertyName("load_1m")]
        public string Load1m { get; set; }

        [JsonPropertyName("load_5m")]
        public string Load5m { get; set; }

        [JsonPropertyName("load_15m")]
        public string Load15m { get; set; }

        [JsonPropertyName("node.role")]
        public string Role { get; set; }

        [JsonPropertyName("master")]
        public string Master { get; set; }

        public Node(string name, string ip, string heapPercent, string ramPercent, string cpu, string load1M, string load5M, string load15M, string role, string master)
        {
            Name = name;
            IP = ip;
            HeapPercent = heapPercent;
            RamPercent = ramPercent;
            CPU = cpu;
            Load1m = load1M;
            Load5m = load5M;
            Load15m = load15M;
            Role = role;
            Master = master;
        }
    }
}
