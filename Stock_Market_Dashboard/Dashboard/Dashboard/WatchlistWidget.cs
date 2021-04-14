using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using DevExpress.XtraBars.Utils;
using System.Globalization;
using System.Diagnostics.SymbolStore;


namespace Dashboard
{
    
    public partial class WatchlistWidget : UserControl
    {
        private int watchlistCounter = 0;
        public WatchlistWidget()
        {
            InitializeComponent();
        }
        private void WatchlistWidget_Load(object sender, EventArgs e)
        {
            WatchlistTimer.Enabled = true;
        }


        private void btnAddStock_Click(object sender, EventArgs e)
        {
            var symbol = txtSymbol.Text.ToUpper();
            NewWatchListRow(symbol);
            txtSymbol.Text = "";
        }

    
        public void NewWatchListRow(String symbol)
        {
            String [] row = GetWatchlistData(symbol);
            if (row != null)
            {
                var lvi = new ListViewItem(row);
                lvWatchlist.Items.Add(lvi);
                watchlistCounter++;
            }

        }

       public string [] GetWatchlistData(String symbol)
        {
            if (symbol == "")
            {
                lblError.Text = "Stock Symbol Needed";
                return null;
            }
            else
            {
                AVConnection conn = new AVConnection();
                List<AlphaVantageData> prices = conn.GetQuoteEndpoint(symbol);
                if (prices.Count == 0)
                {
                    lblError.Text = "Invalid Symbol";
                    return null;
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
                    return row;
                }
            }
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in lvWatchlist.SelectedItems) { lvWatchlist.Items.Remove(eachItem); watchlistCounter--; }

        }
        public void UpdateWatchlist()
        {
            for (int i = 0; i < watchlistCounter; i++)
            {
                String symbol = lvWatchlist.Items[i].SubItems[0].Text;
                String[] row = GetWatchlistData(symbol);
                for (int j = 0; j < lvWatchlist.Columns.Count; j++)
                {
                    lvWatchlist.Items[i].SubItems[j].Text = row[j].ToString();
                   
                }
            }
        }

        private void WatchlistTimer_Tick(object sender, EventArgs e)
        {
            UpdateWatchlist();
        }
    }
}
