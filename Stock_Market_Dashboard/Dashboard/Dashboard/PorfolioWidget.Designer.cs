
namespace Dashboard
{
    partial class PorfolioWidget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PorfolioWidget));
            this.lblPortfolio = new System.Windows.Forms.Label();
            this.TotalValue = new System.Windows.Forms.Label();
            this.TodayGainLoss = new System.Windows.Forms.Label();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.lblTodayGain = new System.Windows.Forms.Label();
            this.lblTotalGain = new System.Windows.Forms.Label();
            this.TotalGainLoss = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbPortfolio = new System.Windows.Forms.TableLayoutPanel();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbPortfolio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPortfolio
            // 
            resources.ApplyResources(this.lblPortfolio, "lblPortfolio");
            this.lblPortfolio.BackColor = System.Drawing.Color.Transparent;
            this.lblPortfolio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPortfolio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPortfolio.Name = "lblPortfolio";
            // 
            // TotalValue
            // 
            resources.ApplyResources(this.TotalValue, "TotalValue");
            this.TotalValue.BackColor = System.Drawing.Color.Transparent;
            this.TotalValue.ForeColor = System.Drawing.Color.DarkGray;
            this.TotalValue.Name = "TotalValue";
            // 
            // TodayGainLoss
            // 
            resources.ApplyResources(this.TodayGainLoss, "TodayGainLoss");
            this.TodayGainLoss.BackColor = System.Drawing.Color.Transparent;
            this.TodayGainLoss.ForeColor = System.Drawing.Color.DarkGray;
            this.TodayGainLoss.Name = "TodayGainLoss";
            // 
            // lblTotalNum
            // 
            resources.ApplyResources(this.lblTotalNum, "lblTotalNum");
            this.lblTotalNum.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalNum.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTotalNum.Name = "lblTotalNum";
            // 
            // lblTodayGain
            // 
            resources.ApplyResources(this.lblTodayGain, "lblTodayGain");
            this.lblTodayGain.BackColor = System.Drawing.Color.Transparent;
            this.lblTodayGain.ForeColor = System.Drawing.Color.White;
            this.lblTodayGain.Name = "lblTodayGain";
            // 
            // lblTotalGain
            // 
            resources.ApplyResources(this.lblTotalGain, "lblTotalGain");
            this.lblTotalGain.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalGain.ForeColor = System.Drawing.Color.White;
            this.lblTotalGain.Name = "lblTotalGain";
            // 
            // TotalGainLoss
            // 
            resources.ApplyResources(this.TotalGainLoss, "TotalGainLoss");
            this.TotalGainLoss.BackColor = System.Drawing.Color.Transparent;
            this.TotalGainLoss.ForeColor = System.Drawing.Color.DarkGray;
            this.TotalGainLoss.Name = "TotalGainLoss";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // tbPortfolio
            // 
            resources.ApplyResources(this.tbPortfolio, "tbPortfolio");
            this.tbPortfolio.Controls.Add(this.lblPercentage, 3, 0);
            this.tbPortfolio.Controls.Add(this.label1, 1, 0);
            this.tbPortfolio.Controls.Add(this.label2, 0, 0);
            this.tbPortfolio.Controls.Add(this.lblPrice, 2, 0);
            this.tbPortfolio.Name = "tbPortfolio";
            // 
            // lblPercentage
            // 
            resources.ApplyResources(this.lblPercentage, "lblPercentage");
            this.lblPercentage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPercentage.ForeColor = System.Drawing.Color.White;
            this.lblPercentage.Name = "lblPercentage";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // lblPrice
            // 
            resources.ApplyResources(this.lblPrice, "lblPrice");
            this.lblPrice.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Name = "lblPrice";
            // 
            // PorfolioWidget
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Dashboard.Properties.Resources.SMD_LoginBG;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tbPortfolio);
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
            resources.ApplyResources(this, "$this");
            this.Name = "PorfolioWidget";
            this.Load += new System.EventHandler(this.PorfolioWidget_Load);
            this.tbPortfolio.ResumeLayout(false);
            this.tbPortfolio.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tbPortfolio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPercentage;
    }
}
