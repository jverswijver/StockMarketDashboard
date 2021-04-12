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
        LayoutMode LayoutMode { get; set; }
        FlowDirection FlowDirection { get; set; }

        //code for rounded corners
        /*
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
        */
        public MainDashboard()
        {
            InitializeComponent();

            //code for rounded corners
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //pnlNav.Height = btnDashbord.Height;
            //pnlNav.Top = btnDashbord.Top;
            //pnlNav.Left = btnDashbord.Left;
            //btnDashbord.BackColor = Color.FromArgb(46, 51, 73);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Passes the username in our settings field to the form label Username and displays it. 
            //lblUsername.Text = Properties.Settings.Default.UserName;
            
            AddDocumentManager();
           
        }

        void AddDocumentManager()
        {
            DocumentManager dM = new DocumentManager(components);
            view = new WidgetView();
            dM.View = view;
            //view.AllowDocumentStateChangeAnimation = DevExpress.Utils.DefaultBoolean.True;
            //view.AllowResizeAnimation = DevExpress.Utils.DefaultBoolean.True;
            //view.AllowStartupAnimation = DevExpress.Utils.DefaultBoolean.True;
            group1 = new StackGroup();
            group2 = new StackGroup();
            group1.Length.UnitType = LengthUnitType.Star;
            group1.Length.UnitValue = 5;
            view.StackGroups.AddRange(new StackGroup[] { group1, group2 });
            
            dM.ContainerControl = this;
            view.LayoutMode = LayoutMode.FreeLayout;
            
            
            view.DocumentSpacing = 3;
            
           
            // view.FlowLayoutProperties.FlowDirection = FlowDirection.LeftToRight;

        }

        int count = 1;

        void AddPortfolio()
        {

            Document portfolioDocument = view.AddDocument(new PortfolioWidget()) as Document;
       
        }

        void AddWatchlist()
        {
            Document document = view.AddDocument(new WatchlistWidget()) as Document;
            //document.MaximizedControl = new ucMaximizedContent();
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
            AddPortfolio();
            //group1.Items.AddRange(new Document[] { view.Documents[0] as Document });

            Console.WriteLine("Opened Portfolio Widget");

        }

        private void btnWatchlist_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAccount.Height;
            pnlNav.Top = btnAccount.Top;
            btnAccount.BackColor = Color.FromArgb(46, 51, 73);
            AddWatchlist();
           // group2.Items.AddRange(new Document[] { view.Documents[0] as Document });
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


        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "  ";
            txtSearch.ForeColor = Color.White;
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

        private void MainDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainDashboard_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            {
                //Allows user to upload an image by clicking on user image box and selecting file
                //Currently image only last until program is closed
                //Will need to store it somehow
                OpenFileDialog fileOpen = new OpenFileDialog();
                fileOpen.Title = "Open Image file";
                fileOpen.Filter = "JPG Files (*.jpg)| *.jpg";

                if (fileOpen.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(fileOpen.FileName);
                }
                fileOpen.Dispose();
            }
        }

        private void lblUserId_Click(object sender, EventArgs e)
        {
            lblUserId.Text = "It's Time To Invest!";
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Kevin's DRAG BAR BLOCK END

    }
}
