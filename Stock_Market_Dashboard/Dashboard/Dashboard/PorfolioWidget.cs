using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        //public virtual System.Windows.Forms.AnchorStyles Anchor { get; set; }

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
        public PorfolioWidget()
        {
            InitializeComponent();

        }


        private void PorfolioWidget_Load(object sender, EventArgs e)
        {
            btnAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 10, 10));
            btnDelete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 10, 10));

            btnAdd.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            lblTotalNum.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            lblPortfolio.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            lblUsername.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            TotalValue.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            TodayGainLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            lblTodayGain.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            TotalGainLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            lblTotalGain.Anchor = (AnchorStyles.Top | AnchorStyles.Left);


        }

    }
}
