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

namespace Dashboard
{
    public partial class AddPositions : UserControl
    {
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
            //if(txtSymbol != null && txtQuantity != null && txtPrice != null && comboBoxType.SelectedIndex == 0)

            GetPortfolioData data = new GetPortfolioData();
            AlphaVantageData stockdata = new AlphaVantageData();


            string symbolPattern = "^[a-zA-Z][^0-9]+";
            string quantityPattern = @"[+-]?([0-9]*[.])?[0-9]+";
            string pricePattern = @"[+-]?([0-9]*[.])?[0-9]+";

            bool symbolIsValid = Regex.IsMatch(txtSymbol.Text, symbolPattern);
            bool quantityIsValid = Regex.IsMatch(txtQuantity.Text, quantityPattern);
            bool priceIsValid = Regex.IsMatch(txtPrice.Text, pricePattern);

            if (txtSymbol.Text == "" || !symbolIsValid)
            {
                errorSymbol.Text = "*Symbol is required!";
                errorSymbol.Visible = true;
            }
            else if (txtSymbol.Text != "" && symbolIsValid)
            {
                errorSymbol.Visible = false;
                data.Symbol = this.txtSymbol.Text.ToUpper();
                //Console.WriteLine(data.Symbol);
            }


            if (txtQuantity.Text == "" || !quantityIsValid)
            {
                errorQuantity.Text = "*Quantity is required!";
                errorQuantity.Visible = true;

            }
            else if (txtQuantity.Text != "" && quantityIsValid)
            {
                errorQuantity.Visible = false;
                data.Quantity = this.txtQuantity.Text;
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
                data.AvgPrice = this.txtPrice.Text;
               // Console.WriteLine(data.AvgPrice);
            }

            if (comboBoxType.SelectedItem == null)
            {
                MessageBox.Show("Please select type!");
            }
            else
            {
                data.Type = comboBoxType.Text;
              //  Console.WriteLine(comboBoxType.Text);
            }

            // addposition.Dispose();


            //Find Gain&Loss Percentage
            var CalculatePercentage = (Convert.ToDouble(getMarketPrice(txtSymbol.Text.ToUpper())) - (Convert.ToDouble(txtPrice.Text)) / (Convert.ToDouble(txtPrice.Text)) * 100);
                var percentGL = Math.Round(CalculatePercentage, 2) + "%";
                data.PercentChange = percentGL.ToString();

            data.MarketPrice = getMarketPrice(txtSymbol.Text.ToUpper());

            String[] row = new string[]{ this.txtSymbol.Text.ToUpper(), this.txtQuantity.Text, this.txtPrice.Text, data.MarketPrice.ToString(), data.PercentChange.ToString() };
           
            //Close AddPositions Window
            Form addposition = this.FindForm();
                addposition.Close();

            data.getPositionRow = row;
           // data.getPositionRow = String.Join(" ", row);

           // addposition.Dispose();
            Console.WriteLine(String.Join(" ", data.getPositionRow));
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



        


