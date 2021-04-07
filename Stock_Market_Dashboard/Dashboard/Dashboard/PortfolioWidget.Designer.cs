
namespace Dashboard
{
    partial class PortfolioWidget
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
            this.components = new System.ComponentModel.Container();
            this.lblPortfolio = new System.Windows.Forms.Label();
            this.TotalValue = new System.Windows.Forms.Label();
            this.TodayGainLoss = new System.Windows.Forms.Label();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.lblTodayGain = new System.Windows.Forms.Label();
            this.lblTotalGain = new System.Windows.Forms.Label();
            this.TotalGainLoss = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.PortfolioListView = new System.Windows.Forms.ListView();
            this.Symbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Shares = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Change = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortfolioTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblPortfolio
            // 
            this.lblPortfolio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPortfolio.AutoSize = true;
            this.lblPortfolio.BackColor = System.Drawing.Color.Transparent;
            this.lblPortfolio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPortfolio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortfolio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPortfolio.Location = new System.Drawing.Point(15, 13);
            this.lblPortfolio.Name = "lblPortfolio";
            this.lblPortfolio.Size = new System.Drawing.Size(131, 24);
            this.lblPortfolio.TabIndex = 11;
            this.lblPortfolio.Text = "My Portfolio";
            // 
            // TotalValue
            // 
            this.TotalValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalValue.AutoSize = true;
            this.TotalValue.BackColor = System.Drawing.Color.Transparent;
            this.TotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TotalValue.ForeColor = System.Drawing.Color.DarkGray;
            this.TotalValue.Location = new System.Drawing.Point(109, 52);
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.Size = new System.Drawing.Size(86, 16);
            this.TotalValue.TabIndex = 12;
            this.TotalValue.Text = "Total Value : ";
            // 
            // TodayGainLoss
            // 
            this.TodayGainLoss.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TodayGainLoss.AutoSize = true;
            this.TodayGainLoss.BackColor = System.Drawing.Color.Transparent;
            this.TodayGainLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TodayGainLoss.ForeColor = System.Drawing.Color.DarkGray;
            this.TodayGainLoss.Location = new System.Drawing.Point(55, 79);
            this.TodayGainLoss.Name = "TodayGainLoss";
            this.TodayGainLoss.Size = new System.Drawing.Size(147, 16);
            this.TodayGainLoss.TabIndex = 13;
            this.TodayGainLoss.Text = "Today Gain/ Loss (%) : ";
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTotalNum.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTotalNum.Location = new System.Drawing.Point(209, 45);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(137, 25);
            this.lblTotalNum.TabIndex = 14;
            this.lblTotalNum.Text = "lblTotalNum";
            // 
            // lblTodayGain
            // 
            this.lblTodayGain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTodayGain.AutoSize = true;
            this.lblTodayGain.BackColor = System.Drawing.Color.Transparent;
            this.lblTodayGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTodayGain.ForeColor = System.Drawing.Color.White;
            this.lblTodayGain.Location = new System.Drawing.Point(211, 77);
            this.lblTodayGain.Name = "lblTodayGain";
            this.lblTodayGain.Size = new System.Drawing.Size(129, 16);
            this.lblTodayGain.TabIndex = 16;
            this.lblTodayGain.Text = "lblTodayGain (%)";
            // 
            // lblTotalGain
            // 
            this.lblTotalGain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalGain.AutoSize = true;
            this.lblTotalGain.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotalGain.ForeColor = System.Drawing.Color.White;
            this.lblTotalGain.Location = new System.Drawing.Point(211, 105);
            this.lblTotalGain.Name = "lblTotalGain";
            this.lblTotalGain.Size = new System.Drawing.Size(120, 16);
            this.lblTotalGain.TabIndex = 18;
            this.lblTotalGain.Text = "lblTotalGain (%)";
            // 
            // TotalGainLoss
            // 
            this.TotalGainLoss.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalGainLoss.AutoSize = true;
            this.TotalGainLoss.BackColor = System.Drawing.Color.Transparent;
            this.TotalGainLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TotalGainLoss.ForeColor = System.Drawing.Color.DarkGray;
            this.TotalGainLoss.Location = new System.Drawing.Point(64, 107);
            this.TotalGainLoss.Name = "TotalGainLoss";
            this.TotalGainLoss.Size = new System.Drawing.Size(138, 16);
            this.TotalGainLoss.TabIndex = 17;
            this.TotalGainLoss.Text = "Total Gain/ Loss (%) : ";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(112, 138);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 31);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "+ Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(214, 138);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 31);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "- Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // PortfolioListView
            // 
            this.PortfolioListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.PortfolioListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PortfolioListView.BackgroundImage = global::Dashboard.Properties.Resources.SMD_LoginBG;
            this.PortfolioListView.BackgroundImageTiled = true;
            this.PortfolioListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Symbol,
            this.Shares,
            this.Price,
            this.Change});
            this.PortfolioListView.ForeColor = System.Drawing.Color.White;
            this.PortfolioListView.GridLines = true;
            this.PortfolioListView.HideSelection = false;
            this.PortfolioListView.Location = new System.Drawing.Point(7, 173);
            this.PortfolioListView.Name = "PortfolioListView";
            this.PortfolioListView.Scrollable = false;
            this.PortfolioListView.Size = new System.Drawing.Size(394, 343);
            this.PortfolioListView.TabIndex = 26;
            this.PortfolioListView.UseCompatibleStateImageBehavior = false;
            this.PortfolioListView.View = System.Windows.Forms.View.Details;
            // 
            // Symbol
            // 
            this.Symbol.Text = "Symbol";
            this.Symbol.Width = 94;
            // 
            // Shares
            // 
            this.Shares.Text = "Shares";
            this.Shares.Width = 102;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 106;
            // 
            // Change
            // 
            this.Change.Text = "Change(%)";
            this.Change.Width = 139;
            // 
            // PortfolioTimer
            // 
            this.PortfolioTimer.Tick += new System.EventHandler(this.PortfolioTimer_Tick);
            // 
            // PortfolioWidget
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Dashboard.Properties.Resources.SMD_LoginBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.PortfolioListView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTotalGain);
            this.Controls.Add(this.TotalGainLoss);
            this.Controls.Add(this.lblTodayGain);
            this.Controls.Add(this.lblTotalNum);
            this.Controls.Add(this.TodayGainLoss);
            this.Controls.Add(this.TotalValue);
            this.Controls.Add(this.lblPortfolio);
            this.DoubleBuffered = true;
            this.Name = "PortfolioWidget";
            this.Size = new System.Drawing.Size(405, 520);
            this.Load += new System.EventHandler(this.PorfolioWidget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPortfolio;
        private System.Windows.Forms.Label TotalValue;
        private System.Windows.Forms.Label TodayGainLoss;
        private System.Windows.Forms.Label lblTotalNum;
        private System.Windows.Forms.Label lblTodayGain;
        private System.Windows.Forms.Label lblTotalGain;
        private System.Windows.Forms.Label TotalGainLoss;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader Symbol;
        private System.Windows.Forms.ColumnHeader Shares;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Change;
        private System.Windows.Forms.Timer PortfolioTimer;
        private System.Windows.Forms.ListView PortfolioListView;
    }
}
