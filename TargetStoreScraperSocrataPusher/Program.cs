using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using CsQuery;
using Newtonsoft.Json;
using SODA;

namespace TargetStoreScraperSocrataPusher
{
    class Program
    {
        static void Main(string[] args)
        {            
            var targetStoresInUSA = new List<Store>();

            StateURLCollection.URLs.ForEach(stateURL =>
            {
                var stateStoresDOM = CQ.CreateFromUrl(stateURL);
                var storeJSON = stateStoresDOM["#primaryJsonResponse"].Text();
                var state = JsonConvert.DeserializeObject<State>(storeJSON);
                targetStoresInUSA = targetStoresInUSA.Concat(state.Stores).ToList();
                Console.WriteLine("Processed: {0}", state.StateName);
            });

            var sodaClient = new SodaClient("opendata.socrata.com", 
                ConfigurationManager.AppSettings["socrataAPIKey"], 
                ConfigurationManager.AppSettings["socrataUsername"],
                ConfigurationManager.AppSettings["socrataPassword"]);

            var targetStoresInUSAJSON = JsonConvert.SerializeObject(targetStoresInUSA);
            Console.WriteLine("Upserting to Socrata");
            sodaClient.Upsert(targetStoresInUSAJSON, SodaDataFormat.JSON, ConfigurationManager.AppSettings["socrataDataset"]);
        }
    }
}
