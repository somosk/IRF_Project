using htlpzf_project.Entities;
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
        List<ExchangeRates> exchangeRates = new List<ExchangeRates>();
        List<GoldPrice> goldPrices = new List<GoldPrice>();
        List<BreadPrice> breadPrices = new List<BreadPrice>();

        public Form1()
        {
            InitializeComponent();

            purchaseDate.Format = DateTimePickerFormat.Custom;
            purchaseDate.CustomFormat = "yyyy/MM";

           sellinDate.Format = DateTimePickerFormat.Custom;
            sellinDate.CustomFormat = "yyyy/MM";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.Multiselect = false;
            //opfd.Filter = "CSV files (.csv)|.csv";
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                string csvpath = opfd.FileName;
                using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {


                        var line = sr.ReadLine().Split(';');
                        goldPrices.Add(new GoldPrice()
                        {
                            year = int.Parse(line[0]),
                            price = double.Parse(line[1])
                        });
                    }
                };
                goldlbl.Text = "Success";
                goldlbl.ForeColor = Color.Green;
                goldPricegrid.DataSource = goldPrices;
            }

        }

        private void LoadBreadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.Multiselect = false;
           // opfd.Filter = "CSV files (.csv)|.csv";
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                string csvpath = opfd.FileName;
                using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {


                        var line = sr.ReadLine().Split(';');
                        breadPrices.Add(new BreadPrice()
                        {
                            year = int.Parse(line[0]),
                            price = double.Parse(line[1])
                        });
                    }
                };
                breadlbl.Text = "Success";
                breadlbl.ForeColor = Color.Green;
                breadPricegrid.DataSource = breadPrices;
            }

        }

        private void LoadEchbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.Multiselect = false;
           // opfd.Filter = "CSV files (.csv)|.csv";
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                string csvpath = opfd.FileName;
                using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {


                        var line = sr.ReadLine().Split(';');
                        exchangeRates.Add(new ExchangeRates()
                        {
                            year = int.Parse(line[0]),
                            Country = line[1],
                            rate = double.Parse(line[2])
                        });
                    }
                };
                exchnglbl.Text = "Success";
                exchnglbl.ForeColor = Color.Green;
                exchngRategrid.DataSource = exchangeRates;
                var distCountries = (from x in exchangeRates select x.Country).Distinct();
                foreach (var item in distCountries)
                {
                    countrycombo.Items.Add(item);
                }
                countrycombo.Enabled = true;

            }
        }
    }
}
