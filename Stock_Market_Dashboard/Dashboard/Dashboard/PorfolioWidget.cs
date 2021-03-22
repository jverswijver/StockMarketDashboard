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
    public partial class PorfolioWidget : Dashboard.ucPreview
    {

        WidgetView view;
        StackGroup group1, group2;

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

        public FlowDocumentCollection FlowLayoutItems { get; }
        public LengthUnitType UnitType { get; set; }
        public ContainerControl ContainerControl { get; set; }

        public System.Windows.Forms.FormWindowState WindowState { get; set; }


        public PorfolioWidget()
        {
            InitializeComponent();
        }


        void AddDocumentManager()
        {
            DocumentManager dM = new DocumentManager(components);
            view = new WidgetView();
            dM.View = view;
            view.AllowDocumentStateChangeAnimation = DevExpress.Utils.DefaultBoolean.True;
            group1 = new StackGroup();
            group2 = new StackGroup();
            group1.Length.UnitType = LengthUnitType.Star;
            group1.Length.UnitValue = 2;
            view.StackGroups.AddRange(new StackGroup[] { group1, group2 });
            dM.ContainerControl = this;
        }

        int count = 1;
        void AddDocumentPosition()
        {
            Document document = view.AddDocument(new AddPositions()) as Document;

            //view.Controller.Dock(view.Documents[1] as Document, group2);

            //document.MaximizedControl = new ucMaximizedContent();
            count++;
        }
        private void PorfolioWidget_Load(object sender, EventArgs e)
        {
            //btnAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 15, 15));
            //btnDelete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 10, 10));

            btnAdd.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            lblTotalNum.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            lblPortfolio.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            TotalValue.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            TodayGainLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            lblTodayGain.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            TotalGainLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            lblTotalGain.Anchor = (AnchorStyles.Top | AnchorStyles.Left);


        }
        private void CreateMyTopMostForm(Form C)
        {
            // Create lower form to display.
            Form bottomForm = new Form();
            // Display the lower form Maximized to demonstrate effect of TopMost property.
            bottomForm.WindowState = FormWindowState.Maximized;
            // Display the bottom form.
            bottomForm.Show();
            // Create the top most form.
            Form topMostForm = new Form();
            // Set the size of the form larger than the default size.
            topMostForm.Size = new Size(300, 300);
            // Set the position of the top most form to center of screen.
            topMostForm.StartPosition = FormStartPosition.CenterScreen;
            // Display the form as top most form.
            topMostForm.TopMost = true;
            topMostForm.Show();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDocumentManager();
            AddDocumentPosition();
            
            group1.Items.AddRange(new Document[] { view.Documents[0] as Document });

        }
    }
}
