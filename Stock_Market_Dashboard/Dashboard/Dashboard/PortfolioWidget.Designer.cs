
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
            this.AvgPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MarketPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Change = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortfolioTimer = new System.Windows.Forms.Timer(this.components);
            this.addPositionPanel = new System.Windows.Forms.Panel();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.requiredQuantity = new System.Windows.Forms.Label();
            this.requiredPrice = new System.Windows.Forms.Label();
            this.requiredSymbol = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblAvgPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTicker = new System.Windows.Forms.Label();
            this.addPositionPanel.SuspendLayout();
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
            this.lblPortfolio.Location = new System.Drawing.Point(79, 13);
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
            this.TotalValue.Location = new System.Drawing.Point(173, 52);
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
            this.TodayGainLoss.Location = new System.Drawing.Point(119, 79);
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
            this.lblTotalNum.Location = new System.Drawing.Point(273, 45);
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
            this.lblTodayGain.Location = new System.Drawing.Point(275, 77);
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
            this.lblTotalGain.Location = new System.Drawing.Point(275, 105);
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
            this.TotalGainLoss.Location = new System.Drawing.Point(128, 107);
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
            this.btnAdd.Location = new System.Drawing.Point(164, 138);
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
            this.btnDelete.Location = new System.Drawing.Point(277, 138);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 31);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "- Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PortfolioListView
            // 
            this.PortfolioListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortfolioListView.BackgroundImage = global::Dashboard.Properties.Resources.SMD_LoginBG;
            this.PortfolioListView.BackgroundImageTiled = true;
            this.PortfolioListView.CheckBoxes = true;
            this.PortfolioListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Symbol,
            this.Shares,
            this.AvgPrice,
            this.MarketPrice,
            this.Change});
            this.PortfolioListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PortfolioListView.ForeColor = System.Drawing.Color.White;
            this.PortfolioListView.FullRowSelect = true;
            this.PortfolioListView.GridLines = true;
            this.PortfolioListView.HideSelection = false;
            this.PortfolioListView.Location = new System.Drawing.Point(1, 334);
            this.PortfolioListView.Name = "PortfolioListView";
            this.PortfolioListView.Scrollable = false;
            this.PortfolioListView.Size = new System.Drawing.Size(530, 545);
            this.PortfolioListView.TabIndex = 26;
            this.PortfolioListView.UseCompatibleStateImageBehavior = false;
            this.PortfolioListView.View = System.Windows.Forms.View.Details;
            // 
            // Symbol
            // 
            this.Symbol.Text = "Symbol";
            this.Symbol.Width = 102;
            // 
            // Shares
            // 
            this.Shares.Text = "Shares";
            this.Shares.Width = 100;
            // 
            // AvgPrice
            // 
            this.AvgPrice.Text = "Avg Price";
            this.AvgPrice.Width = 105;
            // 
            // MarketPrice
            // 
            this.MarketPrice.Text = "Market Price";
            this.MarketPrice.Width = 115;
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
            // addPositionPanel
            // 
            this.addPositionPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addPositionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPositionPanel.Controls.Add(this.lblInvalid);
            this.addPositionPanel.Controls.Add(this.requiredQuantity);
            this.addPositionPanel.Controls.Add(this.requiredPrice);
            this.addPositionPanel.Controls.Add(this.requiredSymbol);
            this.addPositionPanel.Controls.Add(this.btnSubmit);
            this.addPositionPanel.Controls.Add(this.txtPrice);
            this.addPositionPanel.Controls.Add(this.lblAvgPrice);
            this.addPositionPanel.Controls.Add(this.txtQuantity);
            this.addPositionPanel.Controls.Add(this.txtSymbol);
            this.addPositionPanel.Controls.Add(this.lblQuantity);
            this.addPositionPanel.Controls.Add(this.lblTicker);
            this.addPositionPanel.Location = new System.Drawing.Point(119, 173);
            this.addPositionPanel.Name = "addPositionPanel";
            this.addPositionPanel.Size = new System.Drawing.Size(280, 155);
            this.addPositionPanel.TabIndex = 27;
            // 
            // lblInvalid
            // 
            this.lblInvalid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblInvalid.ForeColor = System.Drawing.SystemColors.Info;
            this.lblInvalid.Location = new System.Drawing.Point(15, 124);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(125, 15);
            this.lblInvalid.TabIndex = 33;
            this.lblInvalid.Text = "* Invalid symbol input!";
            this.lblInvalid.Visible = false;
            // 
            // requiredQuantity
            // 
            this.requiredQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.requiredQuantity.AutoSize = true;
            this.requiredQuantity.ForeColor = System.Drawing.Color.Red;
            this.requiredQuantity.Location = new System.Drawing.Point(221, 49);
            this.requiredQuantity.Name = "requiredQuantity";
            this.requiredQuantity.Size = new System.Drawing.Size(15, 20);
            this.requiredQuantity.TabIndex = 32;
            this.requiredQuantity.Text = "*";
            // 
            // requiredPrice
            // 
            this.requiredPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.requiredPrice.AutoSize = true;
            this.requiredPrice.ForeColor = System.Drawing.Color.Red;
            this.requiredPrice.Location = new System.Drawing.Point(221, 85);
            this.requiredPrice.Name = "requiredPrice";
            this.requiredPrice.Size = new System.Drawing.Size(15, 20);
            this.requiredPrice.TabIndex = 31;
            this.requiredPrice.Text = "*";
            // 
            // requiredSymbol
            // 
            this.requiredSymbol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.requiredSymbol.AutoSize = true;
            this.requiredSymbol.ForeColor = System.Drawing.Color.Red;
            this.requiredSymbol.Location = new System.Drawing.Point(221, 14);
            this.requiredSymbol.Name = "requiredSymbol";
            this.requiredSymbol.Size = new System.Drawing.Size(15, 20);
            this.requiredSymbol.TabIndex = 30;
            this.requiredSymbol.Text = "*";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(147, 118);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(74, 27);
            this.btnSubmit.TabIndex = 23;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseCompatibleTextRendering = true;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPrice.Location = new System.Drawing.Point(121, 84);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.Text = "Price";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.WordWrap = false;
            this.txtPrice.Click += new System.EventHandler(this.txtPrice_Click);
            // 
            // lblAvgPrice
            // 
            this.lblAvgPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAvgPrice.AutoSize = true;
            this.lblAvgPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPrice.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAvgPrice.Location = new System.Drawing.Point(68, 85);
            this.lblAvgPrice.Name = "lblAvgPrice";
            this.lblAvgPrice.Size = new System.Drawing.Size(56, 16);
            this.lblAvgPrice.TabIndex = 19;
            this.lblAvgPrice.Text = "Price : ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtQuantity.Location = new System.Drawing.Point(121, 49);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 17;
            this.txtQuantity.Text = "Quantity";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.WordWrap = false;
            this.txtQuantity.Click += new System.EventHandler(this.txtQuantity_Click);
            // 
            // txtSymbol
            // 
            this.txtSymbol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSymbol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSymbol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSymbol.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSymbol.Location = new System.Drawing.Point(121, 14);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(100, 20);
            this.txtSymbol.TabIndex = 16;
            this.txtSymbol.Text = "Symbol";
            this.txtSymbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSymbol.WordWrap = false;
            this.txtSymbol.Click += new System.EventHandler(this.txtSymbol_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblQuantity.Location = new System.Drawing.Point(48, 49);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(76, 16);
            this.lblQuantity.TabIndex = 15;
            this.lblQuantity.Text = "Quantity : ";
            // 
            // lblTicker
            // 
            this.lblTicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTicker.AutoSize = true;
            this.lblTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicker.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTicker.Location = new System.Drawing.Point(52, 14);
            this.lblTicker.Name = "lblTicker";
            this.lblTicker.Size = new System.Drawing.Size(72, 16);
            this.lblTicker.TabIndex = 14;
            this.lblTicker.Text = "Symbol : ";
            // 
            // PortfolioWidget
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Dashboard.Properties.Resources.SMD_LoginBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PortfolioListView);
            this.Controls.Add(this.addPositionPanel);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "PortfolioWidget";
            this.Size = new System.Drawing.Size(532, 725);
            this.Load += new System.EventHandler(this.PortfolioWidget_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PortfolioWidget_MouseDown);
            this.addPositionPanel.ResumeLayout(false);
            this.addPositionPanel.PerformLayout();
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader Symbol;
        private System.Windows.Forms.ColumnHeader Shares;
        private System.Windows.Forms.ColumnHeader AvgPrice;
        private System.Windows.Forms.ColumnHeader Change;
        private System.Windows.Forms.Timer PortfolioTimer;
        private System.Windows.Forms.ColumnHeader MarketPrice;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel addPositionPanel;
        public System.Windows.Forms.TextBox txtQuantity;
        public System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTicker;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblAvgPrice;
        public System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label requiredQuantity;
        private System.Windows.Forms.Label requiredPrice;
        private System.Windows.Forms.Label requiredSymbol;
        private System.Windows.Forms.Label lblInvalid;
        public System.Windows.Forms.ListView PortfolioListView;
    }
}
