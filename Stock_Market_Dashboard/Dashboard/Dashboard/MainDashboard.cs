using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Widget;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking;

namespace Dashboard
{
    public partial class MainDashboard : Form
    {
        WidgetView view;
        StackGroup group1, group2;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse
         );

        public MainDashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;
            btnDashbord.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Passes the username in our settings field to the form label Username and displays it. 
            lblUsername.Text = Properties.Settings.Default.UserName;
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
        void AddDocuments()
        {
            Document document = view.AddDocument(new ucPreview()) as Document;
            document.MaximizedControl = new ucMaximizedContent();
            count++;
        }

        void AddPortfolio()
        {
            Document document = view.AddDocument(new PorfolioWidget()) as Document;
            document.MaximizedControl = new ucMaximizedContent();
            count++;
        }

        void AddWatchlist()
        {
            Document document = view.AddDocument(new WatchlistWidget()) as Document;
            document.MaximizedControl = new ucMaximizedContent();
            count++;
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;
            btnDashbord.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnsettings.Height;
            pnlNav.Top = btnsettings.Top;
            btnsettings.BackColor = Color.FromArgb(46, 51, 73);
            if (btnQuit.Visible == false)
            {
                btnBack.Visible = true;
                btnQuit.Visible = true;

            }
            else
            {
                btnBack.Visible = false;
                btnQuit.Visible = false;
            }
        }

        private void btnDashbord_Leave(object sender, EventArgs e)
        {
            btnDashbord.BackColor = Color.FromArgb(24, 30, 54);
        }


        private void btnCalender_Leave(object sender, EventArgs e)
        {
            btnWatchlist.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnAccount.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnsettings_Leave(object sender, EventArgs e)
        {
            btnsettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logger = new Login();
            logger.Show();
        }

        private void btnPortfolio_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAccount.Height;
            pnlNav.Top = btnAccount.Top;
            btnAccount.BackColor = Color.FromArgb(46, 51, 73);

            


            AddDocumentManager();
            AddPortfolio();
            group1.Items.AddRange(new Document[] { view.Documents[0] as Document });
            Console.WriteLine("Just click the Portfolio");

        }

        private void btnWatchlist_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAccount.Height;
            pnlNav.Top = btnAccount.Top;
            btnAccount.BackColor = Color.FromArgb(46, 51, 73);
            AddDocumentManager();
            AddWatchlist();
            group2.Items.AddRange(new Document[] { view.Documents[0] as Document });
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAccount.Height;
            pnlNav.Top = btnAccount.Top;
            btnAccount.BackColor = Color.FromArgb(46, 51, 73);
        }

        // Kevin's DRAG BAR BLOCK

        public bool mouseDown;
        public Point lastLocation;


        private void MainDashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MainDashboard_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void MainDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
      // Kevin's DRAG BAR BLOCK END

    }
}
