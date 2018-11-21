using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace InfluxData.Platform.Client.Domain
{
    public abstract class AbstractHasLinks
    {
        /**
         * The URIs of resources.
         */
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; set; } = new Dictionary<string, string>();

        protected string LinksToString()
        {
            return string.Join(";", Links.Select(x => x.Key + "=" + x.Value).ToArray());
        }
    }
}