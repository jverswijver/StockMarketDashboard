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

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            var symbol = txtSymbol.Text;
            AVConnection conn = new AVConnection();
            List<AlphaVantageData> prices = conn.GetIntraDayPrices(symbol);
            var currentPrice = prices.Last().Close;
            var row = new string[] { symbol,currentPrice.ToString()};
            var lvi = new ListViewItem(row);
            lvWatchlist.Items.Add(lvi);

        }
    }
}
