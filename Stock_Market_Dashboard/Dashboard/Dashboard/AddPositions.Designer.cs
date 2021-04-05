
namespace Dashboard
{
    partial class AddPositions
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
            this.lblTicker = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAvgPrice = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.errorSymbol = new System.Windows.Forms.Label();
            this.errorQuantity = new System.Windows.Forms.Label();
            this.errorPrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTicker
            // 
            this.lblTicker.AutoSize = true;
            this.lblTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicker.Location = new System.Drawing.Point(20, 81);
            this.lblTicker.Name = "lblTicker";
            this.lblTicker.Size = new System.Drawing.Size(72, 16);
            this.lblTicker.TabIndex = 0;
            this.lblTicker.Text = "Symbol : ";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(16, 117);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(76, 16);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity : ";
            // 
            // lblAvgPrice
            // 
            this.lblAvgPrice.AutoSize = true;
            this.lblAvgPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPrice.Location = new System.Drawing.Point(36, 152);
            this.lblAvgPrice.Name = "lblAvgPrice";
            this.lblAvgPrice.Size = new System.Drawing.Size(56, 16);
            this.lblAvgPrice.TabIndex = 2;
            this.lblAvgPrice.Text = "Price : ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(36, 189);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(56, 16);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 53);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add Position";
            // 
            // txtSymbol
            // 
            this.txtSymbol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSymbol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSymbol.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSymbol.Location = new System.Drawing.Point(98, 81);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(100, 20);
            this.txtSymbol.TabIndex = 6;
            this.txtSymbol.Text = "Symbol  ";
            this.txtSymbol.WordWrap = false;
            this.txtSymbol.Click += new System.EventHandler(this.txtSymbol_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtQuantity.Location = new System.Drawing.Point(98, 117);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.Text = "Quantity";
            this.txtQuantity.WordWrap = false;
            this.txtQuantity.Click += new System.EventHandler(this.txtQuantity_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPrice.Location = new System.Drawing.Point(98, 152);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.Text = "Price";
            this.txtPrice.WordWrap = false;
            this.txtPrice.Click += new System.EventHandler(this.txtPrice_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownHeight = 150;
            this.comboBoxType.DropDownWidth = 100;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.IntegralHeight = false;
            this.comboBoxType.Items.AddRange(new object[] {
            "Buy",
            "Sell"});
            this.comboBoxType.Location = new System.Drawing.Point(98, 189);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxType.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(68, 226);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(102, 28);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // errorSymbol
            // 
            this.errorSymbol.AutoSize = true;
            this.errorSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorSymbol.ForeColor = System.Drawing.Color.Red;
            this.errorSymbol.Location = new System.Drawing.Point(65, 63);
            this.errorSymbol.Name = "errorSymbol";
            this.errorSymbol.Size = new System.Drawing.Size(29, 13);
            this.errorSymbol.TabIndex = 12;
            this.errorSymbol.Text = "Error";
            this.errorSymbol.Visible = false;
            // 
            // errorQuantity
            // 
            this.errorQuantity.AutoSize = true;
            this.errorQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorQuantity.ForeColor = System.Drawing.Color.Red;
            this.errorQuantity.Location = new System.Drawing.Point(63, 102);
            this.errorQuantity.Name = "errorQuantity";
            this.errorQuantity.Size = new System.Drawing.Size(29, 13);
            this.errorQuantity.TabIndex = 13;
            this.errorQuantity.Text = "Error";
            this.errorQuantity.Visible = false;
            // 
            // errorPrice
            // 
            this.errorPrice.AutoSize = true;
            this.errorPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorPrice.ForeColor = System.Drawing.Color.Red;
            this.errorPrice.Location = new System.Drawing.Point(63, 139);
            this.errorPrice.Name = "errorPrice";
            this.errorPrice.Size = new System.Drawing.Size(29, 13);
            this.errorPrice.TabIndex = 14;
            this.errorPrice.Text = "Error";
            this.errorPrice.Visible = false;
            // 
            // AddPositions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.errorPrice);
            this.Controls.Add(this.errorQuantity);
            this.Controls.Add(this.errorSymbol);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAvgPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblTicker);
            this.Name = "AddPositions";
            this.Size = new System.Drawing.Size(229, 273);
            this.Load += new System.EventHandler(this.AddPositions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicker;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAvgPrice;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label errorSymbol;
        private System.Windows.Forms.Label errorQuantity;
        private System.Windows.Forms.Label errorPrice;
    }
}
