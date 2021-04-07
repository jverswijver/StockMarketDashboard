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




namespace Dashboard
{
    public partial class PortfolioWidget : UserControl
    {

        WidgetView view;
        private int PositionCount = 0;

        public PortfolioWidget()
        {
            InitializeComponent();
        }


        void AddDocumentManager()
        {
            DocumentManager dM = new DocumentManager(components);
            view = new WidgetView();

            dM.View = view;
            view.AllowDocumentStateChangeAnimation = DevExpress.Utils.DefaultBoolean.True;
            view.AllowResizeAnimation = DevExpress.Utils.DefaultBoolean.True;

            var portfolio = new PortfolioWidget();
            dM.ContainerControl = portfolio;
            view.LayoutMode = LayoutMode.FreeLayout;
            view.DocumentSpacing = 3;  
        }
         
       // int count = 1;
        AddPositions childForm;
        void AddDocumentPosition()
        {
           // Document portfolioDocument = view.AddDocument(new AddPositions()) as Document;
           
            //Add child form
            var positionWindow = new AddPositions();
            childForm = positionWindow;
            view.AddFloatDocument(positionWindow, new Point(600, 200), new Size(230, 308));

        }
        private void PorfolioWidget_Load(object sender, EventArgs e)
        {
    
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDocumentManager();
            AddDocumentPosition();
           

        }

        public void PortfolioListRow(string[] getPositionRow)
        {
            GetPortfolioData data = new GetPortfolioData();
            
            String[] row = data.getPositionRow; 
            if (row != null)
            {
                var ListItems = new ListViewItem(row);
                PortfolioListView.Items.Add(ListItems);
                PositionCount++;
            }

        }


        public string[] GetPositionData() //string symbol, string quantity, string avgPrice, string marketPrice, string percentChange
        {

            GetPortfolioData data = new GetPortfolioData();
            var S = data.Symbol;
            var Q = data.Quantity;
            var A = data.AvgPrice;
            var M = data.MarketPrice;
            var P = data.PercentChange;


           // PortfolioListRow(data.Symbol, data.Quantity, data.AvgPrice, data.MarketPrice, data.PercentChange);

            var row = new string[] { S.ToString(), Q.ToString(), A.ToString(), M.ToString(), P.ToString() };
            return row;

        }


        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in PortfolioListView.SelectedItems) { PortfolioListView.Items.Remove(eachItem); }

        }
        public void UpdatePosition()
        {
            for (int i = 0; i < PositionCount; i++)
            {
                String symbol = PortfolioListView.Items[i].SubItems[0].Text;
                String quantity = PortfolioListView.Items[i].SubItems[1].Text;
                String avgPrice = PortfolioListView.Items[i].SubItems[2].Text;
                String marketPrice = PortfolioListView.Items[i].SubItems[3].Text;
                String percentChange = PortfolioListView.Items[i].SubItems[4].Text;

                String[] row = GetPositionData();

                for (int j = 0; j < PortfolioListView.Columns.Count; j++)
                {
                    PortfolioListView.Items[i].SubItems[j].Text = row[j].ToString();
                }
            }
        }

        private void PortfolioTimer_Tick(object sender, EventArgs e)
        {
            UpdatePosition();
        }
    }
}
