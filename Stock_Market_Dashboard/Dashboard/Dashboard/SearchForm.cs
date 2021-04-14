using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            AVConnection Kevin = new AVConnection();
            List<string> results = Kevin.SearchEndpoint(textBox1.Text);
            foreach (string x in results)
            {
                listBox1.Items.Add(x);
            }
        }
    }
}
