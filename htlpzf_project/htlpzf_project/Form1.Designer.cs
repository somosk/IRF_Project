namespace htlpzf_project
{
    partial class Form1
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
            this.LoadGoldbtn = new System.Windows.Forms.Button();
            this.LoadBreadbtn = new System.Windows.Forms.Button();
            this.LoadEchbtn = new System.Windows.Forms.Button();
            this.goldlbl = new System.Windows.Forms.Label();
            this.breadlbl = new System.Windows.Forms.Label();
            this.exchnglbl = new System.Windows.Forms.Label();
            this.goldPricegrid = new System.Windows.Forms.DataGridView();
            this.breadPricegrid = new System.Windows.Forms.DataGridView();
            this.exchngRategrid = new System.Windows.Forms.DataGridView();
            this.countrycombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.purchaseDatapanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.sellinDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.purchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.purchaseAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastgrid = new System.Windows.Forms.DataGridView();
            this.exportExcelbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.goldPricegrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadPricegrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchngRategrid)).BeginInit();
            this.purchaseDatapanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadGoldbtn
            // 
            this.LoadGoldbtn.Location = new System.Drawing.Point(12, 12);
            this.LoadGoldbtn.Name = "LoadGoldbtn";
            this.LoadGoldbtn.Size = new System.Drawing.Size(132, 23);
            this.LoadGoldbtn.TabIndex = 0;
            this.LoadGoldbtn.Text = "Load Gold Price";
            this.LoadGoldbtn.UseVisualStyleBackColor = true;
            this.LoadGoldbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoadBreadbtn
            // 
            this.LoadBreadbtn.Location = new System.Drawing.Point(12, 41);
            this.LoadBreadbtn.Name = "LoadBreadbtn";
            this.LoadBreadbtn.Size = new System.Drawing.Size(132, 23);
            this.LoadBreadbtn.TabIndex = 1;
            this.LoadBreadbtn.Text = "Load Bread Price";
            this.LoadBreadbtn.UseVisualStyleBackColor = true;
            this.LoadBreadbtn.Click += new System.EventHandler(this.LoadBreadbtn_Click);
            // 
            // LoadEchbtn
            // 
            this.LoadEchbtn.Location = new System.Drawing.Point(12, 70);
            this.LoadEchbtn.Name = "LoadEchbtn";
            this.LoadEchbtn.Size = new System.Drawing.Size(132, 23);
            this.LoadEchbtn.TabIndex = 2;
            this.LoadEchbtn.Text = "Load Exchange Rates";
            this.LoadEchbtn.UseVisualStyleBackColor = true;
            this.LoadEchbtn.Click += new System.EventHandler(this.LoadEchbtn_Click);
            // 
            // goldlbl
            // 
            this.goldlbl.AutoSize = true;
            this.goldlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goldlbl.ForeColor = System.Drawing.Color.Red;
            this.goldlbl.Location = new System.Drawing.Point(151, 14);
            this.goldlbl.Name = "goldlbl";
            this.goldlbl.Size = new System.Drawing.Size(15, 13);
            this.goldlbl.TabIndex = 3;
            this.goldlbl.Text = "X";
            // 
            // breadlbl
            // 
            this.breadlbl.AutoSize = true;
            this.breadlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.breadlbl.ForeColor = System.Drawing.Color.Red;
            this.breadlbl.Location = new System.Drawing.Point(151, 46);
            this.breadlbl.Name = "breadlbl";
            this.breadlbl.Size = new System.Drawing.Size(15, 13);
            this.breadlbl.TabIndex = 4;
            this.breadlbl.Text = "X";
            // 
            // exchnglbl
            // 
            this.exchnglbl.AutoSize = true;
            this.exchnglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exchnglbl.ForeColor = System.Drawing.Color.Red;
            this.exchnglbl.Location = new System.Drawing.Point(150, 75);
            this.exchnglbl.Name = "exchnglbl";
            this.exchnglbl.Size = new System.Drawing.Size(15, 13);
            this.exchnglbl.TabIndex = 5;
            this.exchnglbl.Text = "X";
            // 
            // goldPricegrid
            // 
            this.goldPricegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goldPricegrid.Location = new System.Drawing.Point(12, 99);
            this.goldPricegrid.Name = "goldPricegrid";
            this.goldPricegrid.Size = new System.Drawing.Size(189, 339);
            this.goldPricegrid.TabIndex = 6;
            // 
            // breadPricegrid
            // 
            this.breadPricegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.breadPricegrid.Location = new System.Drawing.Point(207, 99);
            this.breadPricegrid.Name = "breadPricegrid";
            this.breadPricegrid.Size = new System.Drawing.Size(214, 339);
            this.breadPricegrid.TabIndex = 7;
            // 
            // exchngRategrid
            // 
            this.exchngRategrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exchngRategrid.Location = new System.Drawing.Point(427, 99);
            this.exchngRategrid.Name = "exchngRategrid";
            this.exchngRategrid.Size = new System.Drawing.Size(203, 339);
            this.exchngRategrid.TabIndex = 8;
            // 
            // countrycombo
            // 
            this.countrycombo.Enabled = false;
            this.countrycombo.FormattingEnabled = true;
            this.countrycombo.Location = new System.Drawing.Point(59, 26);
            this.countrycombo.Name = "countrycombo";
            this.countrycombo.Size = new System.Drawing.Size(153, 21);
            this.countrycombo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Investment Data";
            // 
            // purchaseDatapanel
            // 
            this.purchaseDatapanel.Controls.Add(this.button1);
            this.purchaseDatapanel.Controls.Add(this.sellinDate);
            this.purchaseDatapanel.Controls.Add(this.label5);
            this.purchaseDatapanel.Controls.Add(this.purchaseDate);
            this.purchaseDatapanel.Controls.Add(this.label4);
            this.purchaseDatapanel.Controls.Add(this.purchaseAmount);
            this.purchaseDatapanel.Controls.Add(this.label3);
            this.purchaseDatapanel.Controls.Add(this.countrycombo);
            this.purchaseDatapanel.Controls.Add(this.label2);
            this.purchaseDatapanel.Controls.Add(this.label1);
            this.purchaseDatapanel.Location = new System.Drawing.Point(217, 12);
            this.purchaseDatapanel.Name = "purchaseDatapanel";
            this.purchaseDatapanel.Size = new System.Drawing.Size(533, 81);
            this.purchaseDatapanel.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(416, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 55);
            this.button1.TabIndex = 13;
            this.button1.Text = "Create forecast";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sellinDate
            // 
            this.sellinDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sellinDate.Location = new System.Drawing.Point(330, 56);
            this.sellinDate.Name = "sellinDate";
            this.sellinDate.Size = new System.Drawing.Size(80, 20);
            this.sellinDate.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(237, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Selling Date";
            // 
            // purchaseDate
            // 
            this.purchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purchaseDate.Location = new System.Drawing.Point(330, 26);
            this.purchaseDate.Name = "purchaseDate";
            this.purchaseDate.Size = new System.Drawing.Size(80, 20);
            this.purchaseDate.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(237, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Purchase Date";
            // 
            // purchaseAmount
            // 
            this.purchaseAmount.InterceptArrowKeys = false;
            this.purchaseAmount.Location = new System.Drawing.Point(59, 56);
            this.purchaseAmount.Name = "purchaseAmount";
            this.purchaseAmount.Size = new System.Drawing.Size(153, 20);
            this.purchaseAmount.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Amount";
            // 
            // forecastgrid
            // 
            this.forecastgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.forecastgrid.Location = new System.Drawing.Point(636, 99);
            this.forecastgrid.Name = "forecastgrid";
            this.forecastgrid.Size = new System.Drawing.Size(221, 339);
            this.forecastgrid.TabIndex = 13;
            // 
            // exportExcelbtn
            // 
            this.exportExcelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportExcelbtn.Enabled = false;
            this.exportExcelbtn.Location = new System.Drawing.Point(756, 12);
            this.exportExcelbtn.Name = "exportExcelbtn";
            this.exportExcelbtn.Size = new System.Drawing.Size(101, 81);
            this.exportExcelbtn.TabIndex = 18;
            this.exportExcelbtn.Text = "Export to Excel";
            this.exportExcelbtn.UseVisualStyleBackColor = true;
            this.exportExcelbtn.Click += new System.EventHandler(this.exportExcelbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(863, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 153);
            this.panel1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(863, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "Max Sell Price in USD";
            this.label6.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(863, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 180);
            this.panel2.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exportExcelbtn);
            this.Controls.Add(this.forecastgrid);
            this.Controls.Add(this.purchaseDatapanel);
            this.Controls.Add(this.exchngRategrid);
            this.Controls.Add(this.breadPricegrid);
            this.Controls.Add(this.goldPricegrid);
            this.Controls.Add(this.exchnglbl);
            this.Controls.Add(this.breadlbl);
            this.Controls.Add(this.goldlbl);
            this.Controls.Add(this.LoadEchbtn);
            this.Controls.Add(this.LoadBreadbtn);
            this.Controls.Add(this.LoadGoldbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.goldPricegrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadPricegrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchngRategrid)).EndInit();
            this.purchaseDatapanel.ResumeLayout(false);
            this.purchaseDatapanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadGoldbtn;
        private System.Windows.Forms.Button LoadBreadbtn;
        private System.Windows.Forms.Button LoadEchbtn;
        private System.Windows.Forms.Label goldlbl;
        private System.Windows.Forms.Label breadlbl;
        private System.Windows.Forms.Label exchnglbl;
        private System.Windows.Forms.DataGridView goldPricegrid;
        private System.Windows.Forms.DataGridView breadPricegrid;
        private System.Windows.Forms.DataGridView exchngRategrid;
        private System.Windows.Forms.ComboBox countrycombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel purchaseDatapanel;
        private System.Windows.Forms.DateTimePicker purchaseDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown purchaseAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker sellinDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView forecastgrid;
        private System.Windows.Forms.Button exportExcelbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
    }
}

