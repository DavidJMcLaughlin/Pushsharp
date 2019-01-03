using Newtonsoft.Json;
using PushSharp.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Data
{
    /// <summary>
    /// Encapsulates the properties that can be returned from the pushshift comment endpoint
    /// </summary>
    public class Comment : UserContent
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("can_gild")]
        public bool CanGild { get; set; }

        [JsonProperty("collapsed")]
        public bool Collapsed { get; set; }

        [JsonProperty("collapsed_reason")]
        public string CollapsedReason { get; set; }

        [JsonProperty("is_submitter")]
        public bool IsSubmitter { get; set; }

        [JsonProperty("link_id")]
        public string LinkId { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }
    }
}
