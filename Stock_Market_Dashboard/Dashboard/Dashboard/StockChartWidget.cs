using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Dashboard
{
    public partial class StockChartWidget : UserControl
    {
        string stockSymbol;
        public StockChartWidget()
        {
            InitializeComponent();
        }


        private void StockChartWidget_Load(object sender, EventArgs e)
        {
            lblStockChartDay.BackColor = Color.Transparent;
            lblStockChartWeek.BackColor = Color.Transparent;
            lblStockChartMonthly.BackColor = Color.Transparent;
            lblStockChartYearly.BackColor = Color.Transparent;

            Series ser2 = StockChart.Series.Add("line");
            ser2.ChartType = SeriesChartType.Line;
            ChartArea chartArea = StockChart.ChartAreas[0];

            AVConnection conn = new AVConnection();
            List<AlphaVantageData> prices = conn.GetIntraDayPrices("GME");
            CreateGraphLine(prices);
        }


        private void lblStockChartDay_Click(object sender, EventArgs e)
        {
            stockSymbol = txtStockChartSymbol.Text;
            AVConnection conn = new AVConnection();
            List<AlphaVantageData> prices = conn.GetIntraDayPrices(stockSymbol);
            CreateGraphLine(prices);
        }
        private void lblStockChartWeek_Click(object sender, EventArgs e)
        {
            stockSymbol = txtStockChartSymbol.Text;
            AVConnection conn = new AVConnection();
            List<AlphaVantageData> prices = conn.GetWeeklyPrices(stockSymbol);
            CreateGraphLine(prices);
        }

        private void lblStockChartMonthly_Click(object sender, EventArgs e)
        {
            stockSymbol = txtStockChartSymbol.Text;
            AVConnection conn = new AVConnection();
            List<AlphaVantageData> prices = conn.GetMonthlyPrices(stockSymbol);
            CreateGraphLine(prices);
        }

        private void CreateGraphLine(List<AlphaVantageData> prices)
        {
            StockChart.Series.RemoveAt(0);
            Series ser2 = StockChart.Series.Add("line");
            ser2.ChartType = SeriesChartType.Line;
            ChartArea chartArea = StockChart.ChartAreas[0];

            foreach (var items in prices)
            {
                DateTime d = items.Timestamp;
                decimal price = items.Close;
                chartArea.AxisY.Minimum = Math.Round((double)(price - price * 0.1m));
                ser2.Points.AddXY(d, price);
            }
        }

   

        private void lblStockChartYearly_Click(object sender, EventArgs e)
        {

        }
    }
}
    

