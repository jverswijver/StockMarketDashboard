using System;
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
        public StockChartWidget()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StockChartWidget_Load(object sender, EventArgs e)
        {

            AVConnection conn = new AVConnection();
            List<AlphaVantageData> prices = conn.GetIntraDayPrices("MSFT");
            Series ser2 = StockChart.Series.Add("line");
            ser2.ChartType = SeriesChartType.Line;
            ChartArea chartArea = StockChart.ChartAreas[0];
           
           
            foreach (var items in prices)
            {
                DateTime d = items.Timestamp;
                decimal price = items.Close;
                chartArea.AxisY.Minimum = Math.Round((double)(price - price * 0.15m));
                chartArea.RecalculateAxesScale();
                ser2.Points.AddXY(d, price);
            }
        }

    }
}
    

