namespace lastic_view.Models {
    public class ClusterNameUrl {
        public string ClusterName { get; set; }
        public string ClusterUrl { get; set; }

        public ClusterNameUrl(string clusterName, string clusterUrl)
        {
            ClusterName = clusterName;
            ClusterUrl = clusterUrl;
        }
    }
}
