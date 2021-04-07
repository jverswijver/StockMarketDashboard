using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    class GetPortfolioData
    {
        public string Symbol { get; set; }

        public string Quantity { get; set; }

        public string AvgPrice { get; set; }

        public string MarketPrice { get; set; }

        public string PercentChange { get; set; }

        public string Type { get; set; }

        public string [] getPositionRow { get; set; }

    }



        public class SearchResult
        {
            public List<BestMatch> bestMatches { get; set; }
        }

        public class BestMatch
        {

            public string Symbol { get; set; }

            public string Name { get; set; }

            public string Currency { get; set; }
        }


    }

