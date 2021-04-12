using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Configuration;
using Newtonsoft.Json;

namespace Dashboard
{
        class PortfolioItems
        {
             
            public string Type { get; set; }

            public string Symbol { get; set; }

            public string Quantity { get; set; }

            public string AvgPrice { get; set; }

            public string MarketPrice { get; set; }

            public string PercentChange { get; set; }


        }

        class PortfolioList
        {
            public string[] getPositionRow { get; set; }

            public List<string> getPositionList { get; set; }
        }



    public class SearchResult
    {
        [JsonProperty("bestMatches")]
        public List<BestMatch> bestMatches { get; set; }

    }


    public class BestMatch
    {
        [JsonProperty("1. symbol")]
        public string Symbol { get; set; }

        [JsonProperty("2. name")]
        public string Name { get; set; }

        [JsonProperty("8. currency")]
        public string Currency { get; set; }

    }




}
    
    




