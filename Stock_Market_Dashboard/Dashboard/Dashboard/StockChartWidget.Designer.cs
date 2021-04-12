
namespace Dashboard
{
    partial class StockChartWidget
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.StockChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblStockChartDay = new System.Windows.Forms.Label();
            this.lblStockChartMonthly = new System.Windows.Forms.Label();
            this.lblStockChartWeek = new System.Windows.Forms.Label();
            this.lblStockChartYearly = new System.Windows.Forms.Label();
            this.txtStockChartSymbol = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StockChart)).BeginInit();
            this.SuspendLayout();
            // 
            // StockChart
            // 
            this.StockChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.StockChart.ChartAreas.Add(chartArea1);
            this.StockChart.Location = new System.Drawing.Point(3, 40);
            this.StockChart.Name = "StockChart";
            this.StockChart.Size = new System.Drawing.Size(542, 293);
            this.StockChart.TabIndex = 0;
            // 
            // lblStockChartDay
            // 
            this.lblStockChartDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStockChartDay.AutoSize = true;
            this.lblStockChartDay.Location = new System.Drawing.Point(508, 24);
            this.lblStockChartDay.Name = "lblStockChartDay";
            this.lblStockChartDay.Size = new System.Drawing.Size(26, 13);
            this.lblStockChartDay.TabIndex = 1;
            this.lblStockChartDay.Text = "Day";
            this.lblStockChartDay.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStockChartMonthly
            // 
            this.lblStockChartMonthly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStockChartMonthly.AutoSize = true;
            this.lblStockChartMonthly.Location = new System.Drawing.Point(394, 24);
            this.lblStockChartMonthly.Name = "lblStockChartMonthly";
            this.lblStockChartMonthly.Size = new System.Drawing.Size(37, 13);
            this.lblStockChartMonthly.TabIndex = 2;
            this.lblStockChartMonthly.Text = "Month";
            // 
            // lblStockChartWeek
            // 
            this.lblStockChartWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStockChartWeek.AutoSize = true;
            this.lblStockChartWeek.Location = new System.Drawing.Point(453, 24);
            this.lblStockChartWeek.Name = "lblStockChartWeek";
            this.lblStockChartWeek.Size = new System.Drawing.Size(36, 13);
            this.lblStockChartWeek.TabIndex = 3;
            this.lblStockChartWeek.Text = "Week";
            // 
            // lblStockChartYearly
            // 
            this.lblStockChartYearly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStockChartYearly.AutoSize = true;
            this.lblStockChartYearly.Location = new System.Drawing.Point(337, 24);
            this.lblStockChartYearly.Name = "lblStockChartYearly";
            this.lblStockChartYearly.Size = new System.Drawing.Size(36, 13);
            this.lblStockChartYearly.TabIndex = 4;
            this.lblStockChartYearly.Text = "Yearly";
            // 
            // txtStockChartSymbol
            // 
            this.txtStockChartSymbol.Location = new System.Drawing.Point(45, 17);
            this.txtStockChartSymbol.Name = "txtStockChartSymbol";
            this.txtStockChartSymbol.Size = new System.Drawing.Size(100, 20);
            this.txtStockChartSymbol.TabIndex = 5;
            // 
            // StockChartWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dashboard.Properties.Resources.SMD_LoginBG;
            this.Controls.Add(this.txtStockChartSymbol);
            this.Controls.Add(this.lblStockChartYearly);
            this.Controls.Add(this.lblStockChartWeek);
            this.Controls.Add(this.lblStockChartMonthly);
            this.Controls.Add(this.lblStockChartDay);
            this.Controls.Add(this.StockChart);
            this.Name = "StockChartWidget";
            this.Size = new System.Drawing.Size(548, 333);
            this.Load += new System.EventHandler(this.StockChartWidget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart StockChart;
        private System.Windows.Forms.Label lblStockChartDay;
        private System.Windows.Forms.Label lblStockChartMonthly;
        private System.Windows.Forms.Label lblStockChartWeek;
        private System.Windows.Forms.Label lblStockChartYearly;
        private System.Windows.Forms.TextBox txtStockChartSymbol;
    }
}
