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


namespace Dashboard
{
    public partial class AddPositions : UserControl
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // width of ellipse
        int nHeightEllipse // height of ellipse
);
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
                //MessageBox.Show("Please enter Symbol!");
            }
            else if(txtSymbol.Text != "" && symbolIsValid)
            {
                errorSymbol.Visible = false;
            }

        
            if (txtQuantity.Text == "" || !quantityIsValid)
            {
                errorQuantity.Text = "*Quantity is required!";
                errorQuantity.Visible = true;

            }
            else if (txtQuantity.Text != "" && quantityIsValid)
            {
                errorQuantity.Visible = false;
            }


            if (txtPrice.Text == "" || !priceIsValid)
            {
                errorPrice.Text = "*Price is required!";
                errorPrice.Visible = true;
            }

            else if (txtPrice.Text != "" && priceIsValid)
            {
                errorPrice.Visible = false;
            }

            else
            {
               
                //MessageBox.Show("Name should not be left blank!");
            }
        }


      
    }
}

