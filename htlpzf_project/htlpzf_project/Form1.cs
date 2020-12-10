using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace htlpzf_project
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            if (opfd.ShowDialog()==DialogResult.OK)
            {
                string csvpath = opfd.FileName;
                using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {

                    }
                } ;
            }
            
        }
    }
}
