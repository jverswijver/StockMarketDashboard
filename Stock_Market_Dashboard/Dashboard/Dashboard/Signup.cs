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
using System.IO;
using System.Diagnostics;
using System.Reflection;

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
            this.lblAccCreateStatus.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Login logger = new Login();
            logger.Show();
        }
        
        private  bool CheckUserExist()
        {
            List<UserModel> users = new List<UserModel>();
            users = SqliteDataAccess.LoadUsers();
            foreach (var user in users)
            {
                if (user._UserName == txtUsername.Text)
                {
                    lblAccCreateStatus.Text = "User name alreay used";
                    return true;
                }
                if (user._Password == txtPassword.Text)
                {
                    lblAccCreateStatus.Text = "Password already used";
                    return true;
                }
            }
            return false;
            
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            lblAccCreateStatus.ForeColor = Color.Red;
           
            if (txtPassword.Text == "" || txtReenterPass.Text == "" || txtUsername.Text == "")
            {
                lblAccCreateStatus.Text =  "All fields must be filled";
            }
            else if (txtPassword.Text != txtReenterPass.Text)
            {
                lblAccCreateStatus.Text = "Password must match";
            }
            else if(CheckUserExist() == false)
            {
                lblAccCreateStatus.ForeColor = Color.Green;
                lblAccCreateStatus.Text = "Account Created Successfully";
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }
        private void Do_Checked()
            {
                btnSignup.Enabled = checkBox1.Checked;
            }


        //Link for terms and conditions
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //creates a string named rtf which is set to termsandcondiitons file
            //sets rich text box to contain text from file
            //sets the text box to be visible
            //makes the exit button for the text box to display
            string rtf = Dashboard.Properties.Resources.termsAndConditions;
            richTextBox1.Text = rtf;
            richTextBox1.Visible = true;
            button2.Visible = true;


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            //makes text box not visible at start of program


        }


        //sets a boolean for button (exit) click to register if its been pressed
        private bool button2WasClicked = false;

        private void button2_Click(object sender, EventArgs e)
        {
            //if exit button has been pressed
            //set boolean to true
            button2WasClicked = true;
            //if boolean is true
            if (button2WasClicked == true)
            {
                //close out the visibility of the 2
                richTextBox1.Visible = false;
                button2.Visible = false;

            }
        }

       

        // Kevin's DRAG BAR BLOCK END


    }
}
