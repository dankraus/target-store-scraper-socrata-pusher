using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TargetStoreScraperSocrataPusher
{
    class State
    {
        [JsonPropertyAttribute("storeList")]
        public List<Store> Stores { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
    }
}
