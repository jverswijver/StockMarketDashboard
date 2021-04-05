using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    class AlphaVantageData
    {

        public DateTime Timestamp { get; set; }
        public decimal Open { get; set; }

        public decimal High { get; set; }
        public decimal Low { get; set; }

        public decimal Price { get; set; }



        public decimal Close { get; set; }
        public decimal Volume { get; set; }

        public decimal Change { get; set; }

        public String ChangePercent { get; set; }


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


        class AVConnection
        {
            private readonly string _apiKey;

            public AVConnection()
            {
                this._apiKey = "HYAS7FLTSGPVNL2R";
            }

            public List<AlphaVantageData> GetIntraDayPrices(string symbol)
            {
                const string FUNCTION = "TIME_SERIES_DAILY";
                string connectionString = "https://" + $@"www.alphavantage.co/query?function={FUNCTION}&symbol={symbol}&apikey={this._apiKey}&datatype=csv";
                List<AlphaVantageData> prices = connectionString.GetStringFromUrl().FromCsv<List<AlphaVantageData>>();
                return prices;
            }

            public List<AlphaVantageData> GetQuoteEndpoint(string symbol)
            {
                const string FUNCTION = "GLOBAL_QUOTE";
                string connectionString = "https://" + $@"www.alphavantage.co/query?function={FUNCTION}&symbol={symbol}&apikey={this._apiKey}&datatype=csv";
                List<AlphaVantageData> prices = connectionString.GetStringFromUrl().FromCsv<List<AlphaVantageData>>();
                return prices;
            }
        }
    }

