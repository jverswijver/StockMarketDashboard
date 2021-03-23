using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class WatchlistWidget : UserControl
    {
        public WatchlistWidget()
        {
            InitializeComponent();
        }
        private void WatchlistWidget_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            var symbol = txtSymbol.Text.ToUpper();
            GetWatchlistData(symbol);
            txtSymbol.Text = "";
        }

       public void GetWatchlistData(String symbol)
        {
            if (symbol == "")
            {
                lblError.Text = "stock Symbool needed";
            }
            else
            {
                AVConnection conn = new AVConnection();
                List<AlphaVantageData> prices = conn.GetQuoteEndpoint(symbol);
                if (prices.Count == 0)
                {
                    lblError.Text = "Invalid Symbol";
                }
                else
                {
                    var currentPrice = prices.FirstOrDefault().Price;
                    var openPrice = prices.FirstOrDefault().Open;
                    var high = prices.FirstOrDefault().High;
                    var low = prices.FirstOrDefault().Low;
                    var change = prices.First().Change;
                    var percentageChg = prices.FirstOrDefault().ChangePercent;
                    var row = new string[] { symbol, openPrice.ToString(), high.ToString(), low.ToString(), currentPrice.ToString(), change.ToString(), percentageChg };
                    var lvi = new ListViewItem(row);
                    lvWatchlist.Items.Add(lvi);
                }
            }
        }

    }
}
