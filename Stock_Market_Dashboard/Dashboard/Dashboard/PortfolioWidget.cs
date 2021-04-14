using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Widget;
using DevExpress.XtraEditors;
using System.Collections;
using System.Text.RegularExpressions;
using System.Net;
using Newtonsoft.Json;
using ServiceStack;

namespace Dashboard
{
    public partial class PortfolioWidget : UserControl
    {

        private int PositionCount = 0;

        // private AddPositions addPositions;

        public PortfolioWidget()
        {
            InitializeComponent();
            addPositionPanel.Hide();
            PortfolioListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PortfolioListView.Location = new Point(1, 175); 
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            addPositionPanel.Show();
            PortfolioListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PortfolioListView.Location = new Point(229, 335);
            PortfolioListView.Parent = this;
            PortfolioListView.Left = (this.ClientSize.Width - PortfolioListView.Width) / 2;
            PortfolioListView.Top = ((this.ClientSize.Height + 490) - PortfolioListView.Height) / 2;

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            addPositionPanel.Hide();
            PortfolioListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PortfolioListView.Location = new Point(231, 175);
            PortfolioListView.Parent = this;
            PortfolioListView.Left = (this.ClientSize.Width - PortfolioListView.Width) / 2;
            PortfolioListView.Top = ((this.ClientSize.Height + 175) - PortfolioListView.Height) / 2;


            foreach (ListViewItem eachItem in PortfolioListView.SelectedItems) 
            { 
                PortfolioListView.Items.Remove(eachItem); 
            }
        }


        public void UpdatePosition()
        {
            for (int i = 0; i < PositionCount; i++)
            {
                PortfolioList list = new PortfolioList();

                string[] resultRow = list.getPositionRow;

                for (int j = 0; j < PortfolioListView.Columns.Count; j++)
                {
                    PortfolioListView.Items[i].SubItems[j].Text = resultRow[j].ToString();
                }
            }
        }

        private void PortfolioTimer_Tick(object sender, EventArgs e)
        {
            UpdatePosition();
        }


        public string getMarketPrice(string symbol)
        {
            if (symbol == "")
            {
                return null;
            }
            else
            {
                AVConnection connection = new AVConnection();
                List<AlphaVantageData> prices = connection.GetQuoteEndpoint(symbol);
                if (prices.Count == 0)
                {
                    lblInvalid.Visible = true;
                    return null;
                }
                else
                {
                    lblInvalid.Visible = false;
                    return prices.FirstOrDefault().Price.ToString();
                }
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            PortfolioItems data = new PortfolioItems();
            AlphaVantageData stockdata = new AlphaVantageData();

            string symbolPattern = @"[a-zA-Z]{2,4}[^0-9]+";    //@"[A-Z][^0-9]+";
            string quantityPattern = @"[+-]?([0-9]*[.])?[0-9]+";
            string pricePattern = @"[+-]?([0-9]*[.])?[0-9]+";

            bool symbolIsValid = Regex.IsMatch(txtSymbol.Text, symbolPattern);
            bool quantityIsValid = Regex.IsMatch(txtQuantity.Text, quantityPattern);
            bool priceIsValid = Regex.IsMatch(txtPrice.Text, pricePattern);

            try
            {
                if (txtSymbol.Text == "" && txtQuantity.Text == "" && txtPrice.Text == "" )
                {
                    if (txtSymbol.Text == "" || txtQuantity.Text == "" || txtPrice.Text == "" || txtSymbol.Text == "" && txtQuantity.Text == "" 
                        || txtSymbol.Text == "" && txtPrice.Text == "" || txtQuantity.Text == "" &&  txtPrice.Text == "")
                    {
                        MessageBox.Show("Please enter * all required fields!");
                    }

                }

               else if (txtSymbol.Text != "" && txtQuantity.Text != "" && txtPrice.Text != "")
                {

                    if (txtSymbol.Text == "" && txtSymbol.Text == "Symbol" && !symbolIsValid)
                    {
                        //errorSymbol.Text = "*Symbol is required!";
                        requiredSymbol.Visible = true;
                    }
                    else if (txtSymbol.Text != "" && txtSymbol.Text != "Symbol" && symbolIsValid)
                    {
                        requiredSymbol.Visible = false;
                        data.Symbol = txtSymbol.Text.ToUpper(); //Symbol

                        //Console.WriteLine(data.Symbol);
                        // addposition.Dispose();

                    }

                    if (txtQuantity.Text == "" && !quantityIsValid)
                    {
                        // errorQuantity.Text = "*Quantity is required!";
                        requiredQuantity.Visible = true;

                    }
                    else if (txtQuantity.Text != "" && quantityIsValid)
                    {
                        requiredQuantity.Visible = false; //Quantity
                        data.Quantity = txtQuantity.Text.ToString();
                        // Console.WriteLine(data.Quantity);
                    }

                    if (txtPrice.Text == "" && !priceIsValid)
                    {
                        //errorPrice.Text = "*Price is required!";
                        requiredPrice.Visible = true;
                    }

                    else if (txtPrice.Text != "" && priceIsValid)
                    {
                        requiredPrice.Visible = false;
                        data.AvgPrice = txtPrice.Text.ToString(); //AvgPrice
                        // Console.WriteLine(data.AvgPrice);
                    }


                    if(txtSymbol.Text != null && txtSymbol.Text != "" && txtPrice.Text != "")
                    {
                        data.MarketPrice = getMarketPrice(this.txtSymbol.Text.ToUpper()); //MarketPrice

                        //Find Gain&Loss Percentage
                        var CalculatePercentage = (Convert.ToDouble(getMarketPrice(this.txtSymbol.Text.ToUpper())) - (Convert.ToDouble(this.txtPrice.Text))) / (Convert.ToDouble(this.txtPrice.Text)) * 100;
                        var percentGL = Math.Round(CalculatePercentage, 2) + "%";
                        data.PercentChange = percentGL.ToString(); //PercentageChange
                    }

                        String[] row = new string[] {this.txtSymbol.Text.ToUpper(), this.txtQuantity.Text, this.txtPrice.Text, data.MarketPrice.ToString(), data.PercentChange.ToString() };

                        PortfolioList list = new PortfolioList();

                        list.getPositionRow = row;
                        var getP = list.getPositionRow;
                        Console.WriteLine("From Get Position Row: " + String.Join(" ", row));

                        //Add positions in listview
                        var ListItems = new ListViewItem(row);
                        PortfolioListView.Items.Add(ListItems);
                        PositionCount++;

                        addPositionPanel.Hide();
                        txtSymbol.Text = ""; requiredSymbol.Visible = true;
                        txtQuantity.Text = ""; requiredQuantity.Visible = true;
                        txtPrice.Text = ""; requiredPrice.Visible = true;
                        PortfolioListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                        PortfolioListView.Location = new Point(1, 175);
                        PortfolioListView.Parent = this;
                        PortfolioListView.Left = (this.ClientSize.Width - PortfolioListView.Width) / 2;
                        PortfolioListView.Top = ((this.ClientSize.Height + 175) - PortfolioListView.Height) / 2;

                }
  
                else
                {

                    MessageBox.Show("Please enter * all required fields!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter * all required fields!");
                Console.WriteLine(ex.Message);
            }
        }



        private void txtSymbol_Click(object sender, EventArgs e)
        {
            txtSymbol.Text = null;
            txtSymbol.ForeColor = Color.Black;
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {
            txtPrice.Text = null;
            txtPrice.ForeColor = Color.Black;
        }

        private void txtQuantity_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = null;
            txtQuantity.ForeColor = Color.Black;
        }


        private void PortfolioWidget_Load(object sender, EventArgs e)
        {

        }


        public bool mouseDown;
        public Point lastLocation;

        private void PortfolioWidget_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
            Console.WriteLine(lastLocation);
        }
    }
}
