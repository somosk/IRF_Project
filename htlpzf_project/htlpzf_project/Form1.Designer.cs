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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exchnglbl);
            this.Controls.Add(this.breadlbl);
            this.Controls.Add(this.goldlbl);
            this.Controls.Add(this.LoadEchbtn);
            this.Controls.Add(this.LoadBreadbtn);
            this.Controls.Add(this.LoadGoldbtn);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

