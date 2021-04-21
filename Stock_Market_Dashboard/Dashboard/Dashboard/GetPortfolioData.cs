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


}
    
    




