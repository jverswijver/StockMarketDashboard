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

namespace Dashboard
{
    public partial class Signup : Form
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
        public Signup()
        {
            InitializeComponent();
        }

        private void SignupPage_Load(object sender, EventArgs e)
        {
            txtUsername.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtUsername.Width, txtUsername.Height, 15, 15));
            txtPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtPassword.Width, txtPassword.Height, 15, 15));
            txtReenterPass.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtReenterPass.Width, txtReenterPass.Height, 15, 15));
            btnSignup.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSignup.Width, btnSignup.Height, 15, 15));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logger = new Login();
            logger.Show();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtReenterPass.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("All fields must be filled");
            }
            else if (txtPassword.Text != txtReenterPass.Text)
            {
                MessageBox.Show("Passwords must match");
            }
            else
            {
                UserModel U = new UserModel();
                U._UserName = txtUsername.Text.ToLower();
                U._Password = txtPassword.Text;
                SqliteDataAccess.SaveUser(U);
            }
            /*this.Hide();
            MainDashboard dashboard = new MainDashboard();
            dashboard.lblUsername.Text = txtUsername.Text; // Had to change dashboard.lblUsername to PUBLIC to make this work
            dashboard.lblUserId.Text = txtPassword.Text; // Had to change dashboard.lblUserId to PUBLIC to make this work
            dashboard.Show();*/
        }

        // Kevin's DRAG BAR BLOCK

        public bool mouseDown;
        public Point lastLocation;

        private void Signup_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Signup_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Signup_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        // Kevin's DRAG BAR BLOCK END


    }
}
