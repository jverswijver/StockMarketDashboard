using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.Net;
using System.Text.RegularExpressions;
using System.Linq;
using ServiceStack;
using System.Threading.Tasks;
using System.Collections;

namespace Dashboard
{
    public partial class AddPositions : UserControl
    {

        private int PositionCount = 0;
        public AddPositions()
        {
            InitializeComponent();
        }


        private void AddPositions_Load(object sender, EventArgs e)
        {
            //btnSubmit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSubmit.Width, btnSubmit.Height, 15, 15));
        }

        private void txtSymbol_Click(object sender, EventArgs e)
        {
            txtSymbol.Text = "";
            txtSymbol.ForeColor = Color.Black;
        }

        private void txtQuantity_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = "";
            txtQuantity.ForeColor = Color.Black;
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "";
            txtPrice.ForeColor = Color.Black;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {

            PortfolioItems data = new PortfolioItems();
            AlphaVantageData stockdata = new AlphaVantageData();
            //AddPositions addData = new AddPositions();



            string symbolPattern = "[a-zA-Z][^0-9]+";
            string quantityPattern = @"[+-]?([0-9]*[.])?[0-9]+";
            string pricePattern = @"[+-]?([0-9]*[.])?[0-9]+";

            bool symbolIsValid = Regex.IsMatch(txtSymbol.Text, symbolPattern);
            bool quantityIsValid = Regex.IsMatch(txtQuantity.Text, quantityPattern);
            bool priceIsValid = Regex.IsMatch(txtPrice.Text, pricePattern);

            data.Type = comboBoxType.Text;  //Type

            if (txtSymbol.Text == "" || !symbolIsValid)
            {
                errorSymbol.Text = "*Symbol is required!";
                errorSymbol.Visible = true;
            }
            else if (txtSymbol.Text != "" && symbolIsValid)
            {
                errorSymbol.Visible = false;
                data.Symbol = txtSymbol.Text.ToUpper(); //Symbol
                //Console.WriteLine(data.Symbol);
            }


            if (txtQuantity.Text == "" || !quantityIsValid)
            {
                errorQuantity.Text = "*Quantity is required!";
                errorQuantity.Visible = true;

            }
            else if (txtQuantity.Text != "" && quantityIsValid)
            {
                errorQuantity.Visible = false; //Quantity
                data.Quantity = txtQuantity.Text.ToString();
                // Console.WriteLine(data.Quantity);
            }


            if (txtPrice.Text == "" || !priceIsValid)
            {
                errorPrice.Text = "*Price is required!";
                errorPrice.Visible = true;
            }

            else if (txtPrice.Text != "" && priceIsValid)
            {
                errorPrice.Visible = false;
                data.AvgPrice = txtPrice.Text.ToString(); //AvgPrice
                // Console.WriteLine(data.AvgPrice);
            }

            if (comboBoxType.SelectedItem == null)
            {
                MessageBox.Show("Please select type!");
            }


            //  Console.WriteLine(comboBoxType.Text);


            // addposition.Dispose();
            data.MarketPrice = getMarketPrice(this.txtSymbol.Text.ToUpper()); //MarketPrice

            //Find Gain&Loss Percentage
            var CalculatePercentage = (Convert.ToDouble(getMarketPrice(this.txtSymbol.Text.ToUpper())) - (Convert.ToDouble(this.txtPrice.Text))) / (Convert.ToDouble(this.txtPrice.Text)) * 100;
            var percentGL = Math.Round(CalculatePercentage, 2) + "%";
            data.PercentChange = percentGL.ToString(); //PercentageChange



            String[] row = new string[]{ this.comboBoxType.Text, this.txtSymbol.Text.ToUpper(), this.txtQuantity.Text, this.txtPrice.Text, data.MarketPrice.ToString(), data.PercentChange.ToString() };

            PortfolioList list = new PortfolioList();

            list.getPositionRow = row;
            var getP = list.getPositionRow;
            Console.WriteLine("From Get Position Row: " + String.Join(" ",getP));


            //**Try to make a list**//
            //--   list.getPositionList = row.ToList();
            //--  Console.WriteLine("From PositionList" + String.Join(" ", list.getPositionList));



            // pw.UpdatingListView(getP);
            //var getPW = pw.PortfolioListView;
            //ListViewItem pwLv = new ListViewItem()

            // pw.PortfolioListView.Items.Add(Convert.ToString(getP));
            //PortfolioWidget pw = new PortfolioWidget();
            //pw.UpdatingListView(row);


        


            PortfolioWidget pw = new PortfolioWidget();
      
            pw.PortfolioListView.View = View.Details;
            data.Type = comboBoxType.Text;
            data.Symbol = txtSymbol.Text.ToUpper();
            data.Quantity = txtQuantity.Text.ToString();
            data.AvgPrice = txtPrice.Text.ToString();
            data.MarketPrice = getMarketPrice(this.txtSymbol.Text.ToUpper());
            data.PercentChange = getPercent(txtSymbol.Text.ToUpper(), txtPrice.Text.ToString());

            pw.PortfolioListView.Items.Add(new ListViewItem(new string[] { comboBoxType.Text, txtSymbol.Text.ToUpper(), txtQuantity.Text, txtPrice.Text, data.MarketPrice.ToString(), data.PercentChange.ToString() }));
            pw.PortfolioListView.GridLines = true;
            Console.WriteLine(pw.PortfolioListView.ToString());



            //Close AddPositions Window
            Form addposition = this.FindForm();
            addposition.Close();


        }


        public List<string> someData { get; set; }

        public string[] getTheRow()
        {
            String[] row = new string[] { txtSymbol.Text.ToUpper(), txtQuantity.Text, txtPrice.Text, getMarketPrice(txtSymbol.Text).ToString(), getPercent(txtSymbol.Text.ToUpper(), txtPrice.Text).ToString() };
            return row;
        }



        public string getPercent(string symbol, string price)
        {
            var CalculatePercentage = (Convert.ToDouble(getMarketPrice(symbol)) - (Convert.ToDouble(price)) / (Convert.ToDouble(price)) * 100);
            var percentGL = Math.Round(CalculatePercentage, 2) + "%";
            return percentGL;
        }
   
        public string getMarketPrice (string symbol)
        {
            AVConnection connection = new AVConnection();
            List<AlphaVantageData> prices = connection.GetQuoteEndpoint(symbol);
            var currentPrice = prices.FirstOrDefault().Price;

            return currentPrice.ToString();
        }

 
    }
}



        


