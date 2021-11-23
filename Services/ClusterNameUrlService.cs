using System.Threading.Tasks;
using lastic_view.Models;

namespace lastic_view.Services {
    public class ClusterNameUrlService {
        public string currentClusterUrl { get; set; }

        public ClusterNameUrl[] GetClusterUrls()
        {
            ClusterNameUrl logs1 = new ClusterNameUrl("logs-1", "http://logs-ha-1.h.ecentria.com:9201");
            ClusterNameUrl logs2 = new ClusterNameUrl("logs-2", "http://logs-ha-2.h.ecentria.com:9201");
            ClusterNameUrl logs4 = new ClusterNameUrl("logs-4", "http://logs-ha-1.h.ecentria.com:9204");
            ClusterNameUrl[] _cluster = new[]
            {
                logs1, logs2, logs4
            };
            return _cluster;
        }


    }
}
