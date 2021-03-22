namespace Dashboard
{
    partial class WatchlistWidget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnDeleteStock = new System.Windows.Forms.Button();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.lvWatchlist = new System.Windows.Forms.ListView();
            this.Symbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.change = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.percentChange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Open = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.High = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Low = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAddStock
            // 
            this.btnAddStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddStock.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddStock.Location = new System.Drawing.Point(222, 14);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(83, 33);
            this.btnAddStock.TabIndex = 20;
            this.btnAddStock.Text = "+ Add";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteStock.AutoSize = true;
            this.btnDeleteStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteStock.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStock.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteStock.Location = new System.Drawing.Point(317, 14);
            this.btnDeleteStock.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(82, 33);
            this.btnDeleteStock.TabIndex = 21;
            this.btnDeleteStock.Text = "- Delete";
            this.btnDeleteStock.UseVisualStyleBackColor = false;
            // 
            // txtSymbol
            // 
            this.txtSymbol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSymbol.Location = new System.Drawing.Point(124, 23);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(80, 20);
            this.txtSymbol.TabIndex = 22;
            // 
            // lvWatchlist
            // 
            this.lvWatchlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lvWatchlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(36)))));
            this.lvWatchlist.BackgroundImage = global::Dashboard.Properties.Resources.SMD_LoginBG;
            this.lvWatchlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Symbol,
            this.Open,
            this.High,
            this.Low,
            this.Price,
            this.change,
            this.percentChange});
            this.lvWatchlist.ForeColor = System.Drawing.Color.White;
            this.lvWatchlist.GridLines = true;
            this.lvWatchlist.HideSelection = false;
            this.lvWatchlist.Location = new System.Drawing.Point(3, 51);
            this.lvWatchlist.Name = "lvWatchlist";
            this.lvWatchlist.Scrollable = false;
            this.lvWatchlist.Size = new System.Drawing.Size(427, 333);
            this.lvWatchlist.TabIndex = 23;
            this.lvWatchlist.UseCompatibleStateImageBehavior = false;
            this.lvWatchlist.View = System.Windows.Forms.View.Details;
            // 
            // Symbol
            // 
            this.Symbol.Text = "Symbol";
            this.Symbol.Width = 84;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 55;
            // 
            // change
            // 
            this.change.Text = "chg.";
            this.change.Width = 49;
            // 
            // percentChange
            // 
            this.percentChange.Text = "%Chg.";
            this.percentChange.Width = 59;
            // 
            // Open
            // 
            this.Open.Text = "Open";
            this.Open.Width = 69;
            // 
            // High
            // 
            this.High.Text = "High";
            // 
            // Low
            // 
            this.Low.Text = "Low";
            // 
            // WatchlistWidget
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImage = global::Dashboard.Properties.Resources.SMD_LoginBG;
            this.Controls.Add(this.lvWatchlist);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.btnDeleteStock);
            this.Controls.Add(this.btnAddStock);
            this.Name = "WatchlistWidget";
            this.Size = new System.Drawing.Size(433, 382);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnDeleteStock;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.ListView lvWatchlist;
        private System.Windows.Forms.ColumnHeader Symbol;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader change;
        private System.Windows.Forms.ColumnHeader percentChange;
        private System.Windows.Forms.ColumnHeader Open;
        private System.Windows.Forms.ColumnHeader High;
        private System.Windows.Forms.ColumnHeader Low;
    }
}
