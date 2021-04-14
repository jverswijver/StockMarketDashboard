using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Login : Form
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
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            
            txtUsername.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtUsername.Width, txtUsername.Height, 15, 15));
            txtPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtPassword.Width, txtPassword.Height, 15, 15));
            btnSignin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSignin.Width, btnSignin.Height, 15, 15));
            
            
            //IF the fields in property are empty, itll display empty username and password fields on load up.
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Text = "";
        }

        private void btnSignin_MouseClick(object sender, MouseEventArgs e)
        {
            btnSignin.BackColor = System.Drawing.Color.MediumSpringGreen;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.Show();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            List<UserModel> users = new List<UserModel>();
            users = SqliteDataAccess.LoadUsers();
            foreach(var user in users)
            {
                if (user._UserName == txtUsername.Text.ToLower() && user._Password == txtPassword.Text.ToLower())
                {
                    this.Hide();
                    MainDashboard dashboard = new MainDashboard();
                    RememberMe();
                    dashboard.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("Incorrect Username and Password");
                    txtPassword.Text = "";
                    break;
                }
                
            }
       
            //Old code before check box was installed incase it breaks somehow. 
            //this.Hide();
            //MainDashboard dashboard = new MainDashboard();
            //dashboard.lblUsername.Text = txtUsername.Text; // Had to change dashboard.lblUsername to PUBLIC to make this work
            //dashboard.lblUserId.Text = txtPassword.Text; // Had to change dashboard.lblUserId to PUBLIC to make this work
            //dashboard.Show();*/
        }
        private void RememberMe()
        {
            if (rememberMeBox1.Checked == true)
            {
                Properties.Settings.Default.UserName = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Save();
            }

            if (rememberMeBox1.Checked == false)
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }

        // Kevin's DRAG BAR BLOCK

        public bool mouseDown;
        public Point lastLocation;

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        // Kevin's DRAG BAR BLOCK END
    }
}
