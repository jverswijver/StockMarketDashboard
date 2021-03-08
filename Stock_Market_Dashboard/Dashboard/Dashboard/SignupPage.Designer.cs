
namespace Dashboard
{
    partial class SignupPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnGoBack;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupPage));
            this.button1 = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtReenterPass = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblReenterPass = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblOptional = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblGoBack = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.smdLogo = new System.Windows.Forms.PictureBox();
            btnGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smdLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoBack
            // 
            btnGoBack.BackColor = System.Drawing.Color.Transparent;
            btnGoBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnGoBack.FlatAppearance.BorderSize = 0;
            btnGoBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnGoBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGoBack.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnGoBack.ForeColor = System.Drawing.Color.Transparent;
            btnGoBack.Image = ((System.Drawing.Image)(resources.GetObject("btnGoBack.Image")));
            btnGoBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnGoBack.Location = new System.Drawing.Point(27, 392);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new System.Drawing.Size(70, 81);
            btnGoBack.TabIndex = 42;
            btnGoBack.TabStop = false;
            btnGoBack.UseMnemonic = false;
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(878, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 22;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.lbltitle.Font = new System.Drawing.Font("Nirmala UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lbltitle.Location = new System.Drawing.Point(196, 40);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(387, 59);
            this.lbltitle.TabIndex = 20;
            this.lbltitle.Text = "Create an account";
            // 
            // txtUsername
            // 
            this.txtUsername.AcceptsReturn = true;
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(285, 131);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(203, 29);
            this.txtUsername.TabIndex = 23;
            this.txtUsername.TabStop = false;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.WordWrap = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(285, 192);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(203, 29);
            this.txtPassword.TabIndex = 24;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.WordWrap = false;
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSignup.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.Black;
            this.btnSignup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSignup.Location = new System.Drawing.Point(285, 389);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(200, 32);
            this.btnSignup.TabIndex = 25;
            this.btnSignup.Text = "SIGN UP";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblUsername.Location = new System.Drawing.Point(174, 141);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 19);
            this.lblUsername.TabIndex = 28;
            this.lblUsername.Text = "Username *";
            // 
            // txtReenterPass
            // 
            this.txtReenterPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtReenterPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReenterPass.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtReenterPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtReenterPass.Location = new System.Drawing.Point(285, 251);
            this.txtReenterPass.Name = "txtReenterPass";
            this.txtReenterPass.Size = new System.Drawing.Size(203, 29);
            this.txtReenterPass.TabIndex = 30;
            this.txtReenterPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReenterPass.WordWrap = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblPassword.Location = new System.Drawing.Point(173, 196);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(96, 19);
            this.lblPassword.TabIndex = 31;
            this.lblPassword.Text = "Password *";
            // 
            // lblReenterPass
            // 
            this.lblReenterPass.AutoSize = true;
            this.lblReenterPass.BackColor = System.Drawing.Color.Transparent;
            this.lblReenterPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReenterPass.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblReenterPass.Location = new System.Drawing.Point(109, 255);
            this.lblReenterPass.Name = "lblReenterPass";
            this.lblReenterPass.Size = new System.Drawing.Size(165, 19);
            this.lblReenterPass.TabIndex = 32;
            this.lblReenterPass.Text = "Re-enter Password *";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.Transparent;
            this.lblDOB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblDOB.Location = new System.Drawing.Point(157, 316);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(102, 19);
            this.lblDOB.TabIndex = 34;
            this.lblDOB.Text = "Date of birth";
            // 
            // lblOptional
            // 
            this.lblOptional.AutoSize = true;
            this.lblOptional.BackColor = System.Drawing.Color.Transparent;
            this.lblOptional.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptional.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblOptional.Location = new System.Drawing.Point(500, 321);
            this.lblOptional.Name = "lblOptional";
            this.lblOptional.Size = new System.Drawing.Size(83, 19);
            this.lblOptional.TabIndex = 35;
            this.lblOptional.Text = "(Optional)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(285, 320);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(688, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 29);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGoBack
            // 
            this.lblGoBack.AutoSize = true;
            this.lblGoBack.BackColor = System.Drawing.Color.Transparent;
            this.lblGoBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoBack.ForeColor = System.Drawing.Color.White;
            this.lblGoBack.Location = new System.Drawing.Point(23, 476);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(74, 19);
            this.lblGoBack.TabIndex = 40;
            this.lblGoBack.Text = "Go Back";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(57, 386);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 85);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // smdLogo
            // 
            this.smdLogo.BackColor = System.Drawing.Color.Transparent;
            this.smdLogo.Image = ((System.Drawing.Image)(resources.GetObject("smdLogo.Image")));
            this.smdLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.smdLogo.Location = new System.Drawing.Point(27, 28);
            this.smdLogo.Name = "smdLogo";
            this.smdLogo.Size = new System.Drawing.Size(135, 113);
            this.smdLogo.TabIndex = 41;
            this.smdLogo.TabStop = false;
            // 
            // SignupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(717, 513);
            this.ControlBox = false;
            this.Controls.Add(btnGoBack);
            this.Controls.Add(this.smdLogo);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblOptional);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblReenterPass);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtReenterPass);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltitle);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignupPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SignupPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smdLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtReenterPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblReenterPass;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblOptional;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGoBack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox smdLogo;
    }
}