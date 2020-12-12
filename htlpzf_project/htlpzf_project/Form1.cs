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
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;


namespace htlpzf_project
{
    public partial class Form1 : Form
    {
        
        List<ExchangeRates> exchangeRates = new List<ExchangeRates>();
        List<GoldPrice> goldPrices = new List<GoldPrice>();
        List<BreadPrice> breadPrices = new List<BreadPrice>();


        Excel.Application xlApp; // A Microsoft Excel alkalmazás
        Excel.Workbook xlWB; // A létrehozott munkafüzet
        Excel.Worksheet xlSheet; // Munkalap a munkafüzeten belül

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
                            Country = (CountyEnum)Enum.Parse(typeof(CountyEnum), line[1]),
                            rate = double.Parse(line[2]),
                            countrycode= int.Parse(line[1])
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
        List<ForeCast> foreCast = new List<ForeCast>();
        private void button1_Click_1(object sender, EventArgs e)
        {
            foreCast.Clear();
            if (countrycombo.SelectedItem==null || purchaseAmount.Value==0 || purchaseDate.Value>sellinDate.Value)
            {
                MessageBox.Show("Please fill/correct purchase data!");
            }
            else
            {
                for (int i = purchaseDate.Value.Year; i <= sellinDate.Value.Year ; i++)
                {
                    foreCast.Add(new ForeCast()
                    {
                        _year = i
                        
                    });
                    

                }
                
                forecastgrid.DataSource = foreCast;
                    
            }
            exportExcelbtn.Enabled = true;
            label6.Visible = true;
            DrawNumber();
        }

        private void exportExcelbtn_Click(object sender, EventArgs e)
        {
            CreateExcel();
            CreateTable();

            
            //Shine();
        }

        private void Shine()
        {
            /*panel2.Controls.Clear();
            List<Control> ctrls = new List<Control>();
            foreach (Control c in panel1.Controls)
            {
                ctrls.Add(c);
            }
            
            panel2.Controls.AddRange(ctrls.ToArray());*/
            
        }

        public string maxvalue;
        public bool[,] bg = new bool[36,36];
        //List<bool> bg = new List<bool>();
        
        private void DrawNumber()
        {
            panel1.Controls.Clear();
            maxvalue = (Math.Round((from x in foreCast select x.gold).Max(),0)).ToString();
            for (int i = 0; i < maxvalue.Length; i++)
            {
                string szamjegy = maxvalue[i].ToString();
                switch (szamjegy)
                {
                    case "1":
                              bg[1, 1] =false; 
                              bg[1, 2] =false;
                              bg[1, 3] =false;
                              bg[1, 4] =false;
                              bg[1, 5] =false;
                              bg[1, 6] =false;
                              bg[1, 7] =false;
                              bg[1, 8] =false;
                              bg[1, 9] =false;

                              bg[2, 1] = false;
                              bg[2, 2] = false;
                              bg[2, 3] = false;
                              bg[2, 4] = false;
                              bg[2, 5] = false;
                              bg[2, 6] = false;
                              bg[2, 7] = false;
                              bg[2, 8] = false;
                              bg[2, 9] = false;
                              bg[3, 1] =false;

                              bg[3, 2] =false;
                              bg[3, 3] =false;
                              bg[3, 4] =false;
                              bg[3, 5] =false;
                              bg[3, 6] =false;
                              bg[3, 7] =false;
                              bg[3, 8] =false;
                              bg[3, 9] =false;

                              bg[4, 1] =true;
                              bg[4, 2] =true;
                              bg[4, 3] =true;
                              bg[4, 4] =true;
                              bg[4, 5] =true;
                              bg[4, 6] =true;
                              bg[4, 7] =true;
                              bg[4, 8] =true;
                              bg[4, 9] = true;

                        break;

                    case "2":
                        bg[1, 1] = true;
                        bg[1, 2] = false;
                        bg[1, 3] = false;
                        bg[1, 4] = false;
                        bg[1, 5] = true;
                        bg[1, 6] = true;
                        bg[1, 7] = true;
                        bg[1, 8] = true;
                        bg[1, 9] = true;

                        bg[2, 1] = true;
                        bg[2, 2] = false;
                        bg[2, 3] = false;
                        bg[2, 4] = false;
                        bg[2, 5] = true;
                        bg[2, 6] = false;
                        bg[2, 7] = false;
                        bg[2, 8] = false;
                        bg[2, 9] = true;

                        bg[3, 1] = true;
                        bg[3, 2] = false;
                        bg[3, 3] = false;
                        bg[3, 4] = false;
                        bg[3, 5] = true;
                        bg[3, 6] = false;
                        bg[3, 7] = false;
                        bg[3, 8] = false;
                        bg[3, 9] = true;

                        bg[4, 1] = true;
                        bg[4, 2] = true;
                        bg[4, 3] = true;
                        bg[4, 4] = true;
                        bg[4, 5] = true;
                        bg[4, 6] = false;
                        bg[4, 7] = false;
                        bg[4, 8] = false;
                        bg[4, 9] = true;

                        break;

                    case "3":
                        bg[1, 1] = true;
                        bg[1, 2] = false;
                        bg[1, 3] = false;
                        bg[1, 4] = false;
                        bg[1, 5] = false;
                        bg[1, 6] = false;
                        bg[1, 7] = false;
                        bg[1, 8] = false;
                        bg[1, 9] = true;

                        bg[2, 1] = true;
                        bg[2, 2] = false;
                        bg[2, 3] = false;
                        bg[2, 4] = false;
                        bg[2, 5] = true;
                        bg[2, 6] = false;
                        bg[2, 7] = false;
                        bg[2, 8] = false;
                        bg[2, 9] = true;

                        bg[3, 1] = true;
                        bg[3, 2] = false;
                        bg[3, 3] = false;
                        bg[3, 4] = false;
                        bg[3, 5] = true;
                        bg[3, 6] = false;
                        bg[3, 7] = false;
                        bg[3, 8] = false;
                        bg[3, 9] = true;

                        bg[4, 1] = true;
                        bg[4, 2] = true;
                        bg[4, 3] = true;
                        bg[4, 4] = true;
                        bg[4, 5] = true;
                        bg[4, 6] = true;
                        bg[4, 7] = true;
                        bg[4, 8] = true;
                        bg[4, 9] = true;

                        break;

                    case "4":
                        bg[1, 1] = true;
                        bg[1, 2] = true;
                        bg[1, 3] = true;
                        bg[1, 4] = true;
                        bg[1, 5] = true;
                        bg[1, 6] = false;
                        bg[1, 7] = false;
                        bg[1, 8] = false;
                        bg[1, 9] = false;

                        bg[2, 1] = false;
                        bg[2, 2] = false;
                        bg[2, 3] = false;
                        bg[2, 4] = false;
                        bg[2, 5] = true;
                        bg[2, 6] = false;
                        bg[2, 7] = false;
                        bg[2, 8] = false;
                        bg[2, 9] = false;

                        bg[3, 1] = false;
                        bg[3, 2] = false;
                        bg[3, 3] = false;
                        bg[3, 4] = false;
                        bg[3, 5] = true;
                        bg[3, 6] = false;
                        bg[3, 7] = false;
                        bg[3, 8] = false;
                        bg[3, 9] = false;

                        bg[4, 1] = true;
                        bg[4, 2] = true;
                        bg[4, 3] = true;
                        bg[4, 4] = true;
                        bg[4, 5] = true;
                        bg[4, 6] = true;
                        bg[4, 7] = true;
                        bg[4, 8] = true;
                        bg[4, 9] = true;

                        break;

                    case "5":
                        bg[1, 1] = true;
                        bg[1, 2] = true;
                        bg[1, 3] = true;
                        bg[1, 4] = true;
                        bg[1, 5] = true;
                        bg[1, 6] = false;
                        bg[1, 7] = false;
                        bg[1, 8] = false;
                        bg[1, 9] = true;

                        bg[2, 1] = true;
                        bg[2, 2] = false;
                        bg[2, 3] = false;
                        bg[2, 4] = false;
                        bg[2, 5] = true;
                        bg[2, 6] = false;
                        bg[2, 7] = false;
                        bg[2, 8] = false;
                        bg[2, 9] = true;

                        bg[3, 1] = true;
                        bg[3, 2] = false;
                        bg[3, 3] = false;
                        bg[3, 4] = false;
                        bg[3, 5] = true;
                        bg[3, 6] = false;
                        bg[3, 7] = false;
                        bg[3, 8] = false;
                        bg[3, 9] = true;

                        bg[4, 1] = true;
                        bg[4, 2] = false;
                        bg[4, 3] = false;
                        bg[4, 4] = false;
                        bg[4, 5] = true;
                        bg[4, 6] = true;
                        bg[4, 7] = true;
                        bg[4, 8] = true;
                        bg[4, 9] = true;

                        break;

                    case "6":
                        bg[1, 1] = true;
                        bg[1, 2] = true;
                        bg[1, 3] = true;
                        bg[1, 4] = true;
                        bg[1, 5] = true;
                        bg[1, 6] = true;
                        bg[1, 7] = true;
                        bg[1, 8] = true;
                        bg[1, 9] = true;

                        bg[2, 1] = true;
                        bg[2, 2] = false;
                        bg[2, 3] = false;
                        bg[2, 4] = false;
                        bg[2, 5] = true;
                        bg[2, 6] = false;
                        bg[2, 7] = false;
                        bg[2, 8] = false;
                        bg[2, 9] = true;

                        bg[3, 1] = true;
                        bg[3, 2] = false;
                        bg[3, 3] = false;
                        bg[3, 4] = false;
                        bg[3, 5] = true;
                        bg[3, 6] = false;
                        bg[3, 7] = false;
                        bg[3, 8] = false;
                        bg[3, 9] = true;

                        bg[4, 1] = true;
                        bg[4, 2] = false;
                        bg[4, 3] = false;
                        bg[4, 4] = false;
                        bg[4, 5] = true;
                        bg[4, 6] = true;
                        bg[4, 7] = true;
                        bg[4, 8] = true;
                        bg[4, 9] = true;

                        break;

                    case "7":
                        bg[1, 1] = false;
                        bg[1, 2] = false;
                        bg[1, 3] = false;
                        bg[1, 4] = false;
                        bg[1, 5] = false;
                        bg[1, 6] = false;
                        bg[1, 7] = false;
                        bg[1, 8] = false;
                        bg[1, 9] = false;

                        bg[2, 1] = true;
                        bg[2, 2] = false;
                        bg[2, 3] = false;
                        bg[2, 4] = false;
                        bg[2, 5] = false;
                        bg[2, 6] = false;
                        bg[2, 7] = false;
                        bg[2, 8] = false;
                        bg[2, 9] = false;

                        bg[3, 1] = true;
                        bg[3, 2] = false;
                        bg[3, 3] = false;
                        bg[3, 4] = false;
                        bg[3, 5] = false;
                        bg[3, 6] = false;
                        bg[3, 7] = false;
                        bg[3, 8] = false;
                        bg[3, 9] = false;

                        bg[4, 1] = true;
                        bg[4, 2] = true;
                        bg[4, 3] = true;
                        bg[4, 4] = true;
                        bg[4, 5] = true;
                        bg[4, 6] = true;
                        bg[4, 7] = true;
                        bg[4, 8] = true;
                        bg[4, 9] = true;

                        break;

                    case "8":
                        bg[1, 1] = true;
                        bg[1, 2] = true;
                        bg[1, 3] = true;
                        bg[1, 4] = true;
                        bg[1, 5] = true;
                        bg[1, 6] = true;
                        bg[1, 7] = true;
                        bg[1, 8] = true;
                        bg[1, 9] = true;

                        bg[2, 1] = true;
                        bg[2, 2] = false;
                        bg[2, 3] = false;
                        bg[2, 4] = false;
                        bg[2, 5] = true;
                        bg[2, 6] = false;
                        bg[2, 7] = false;
                        bg[2, 8] = false;
                        bg[2, 9] = true;

                        bg[3, 1] = true;
                        bg[3, 2] = false;
                        bg[3, 3] = false;
                        bg[3, 4] = false;
                        bg[3, 5] = true;
                        bg[3, 6] = false;
                        bg[3, 7] = false;
                        bg[3, 8] = false;
                        bg[3, 9] = true;

                        bg[4, 1] = true;
                        bg[4, 2] = true;
                        bg[4, 3] = true;
                        bg[4, 4] = true;
                        bg[4, 5] = true;
                        bg[4, 6] = true;
                        bg[4, 7] = true;
                        bg[4, 8] = true;
                        bg[4, 9] = true;

                        break;

                    case "9":
                        bg[1, 1] = true;
                        bg[1, 2] = true;
                        bg[1, 3] = true;
                        bg[1, 4] = true;
                        bg[1, 5] = true;
                        bg[1, 6] = false;
                        bg[1, 7] = false;
                        bg[1, 8] = false;
                        bg[1, 9] = true;

                        bg[2, 1] = true;
                        bg[2, 2] = false;
                        bg[2, 3] = false;
                        bg[2, 4] = false;
                        bg[2, 5] = true;
                        bg[2, 6] = false;
                        bg[2, 7] = false;
                        bg[2, 8] = false;
                        bg[2, 9] = true;

                        bg[3, 1] = true;
                        bg[3, 2] = false;
                        bg[3, 3] = false;
                        bg[3, 4] = false;
                        bg[3, 5] = true;
                        bg[3, 6] = false;
                        bg[3, 7] = false;
                        bg[3, 8] = false;
                        bg[3, 9] = true;

                        bg[4, 1] = true;
                        bg[4, 2] = true;
                        bg[4, 3] = true;
                        bg[4, 4] = true;
                        bg[4, 5] = true;
                        bg[4, 6] = true;
                        bg[4, 7] = true;
                        bg[4, 8] = true;
                        bg[4, 9] = true;

                        break;
                    case "0":
                        bg[1, 1] = true;
                        bg[1, 2] = true;
                        bg[1, 3] = true;
                        bg[1, 4] = true;
                        bg[1, 5] = true;
                        bg[1, 6] = true;
                        bg[1, 7] = true;
                        bg[1, 8] = true;
                        bg[1, 9] = true;

                        bg[2, 1] = true;
                        bg[2, 2] = false;
                        bg[2, 3] = false;
                        bg[2, 4] = false;
                        bg[2, 5] = false;
                        bg[2, 6] = false;
                        bg[2, 7] = false;
                        bg[2, 8] = false;
                        bg[2, 9] = true;

                        bg[3, 1] = true;
                        bg[3, 2] = false;
                        bg[3, 3] = false;
                        bg[3, 4] = false;
                        bg[3, 5] = false;
                        bg[3, 6] = false;
                        bg[3, 7] = false;
                        bg[3, 8] = false;
                        bg[3, 9] = true;

                        bg[4, 1] = true;
                        bg[4, 2] = true;
                        bg[4, 3] = true;
                        bg[4, 4] = true;
                        bg[4, 5] = true;
                        bg[4, 6] = true;
                        bg[4, 7] = true;
                        bg[4, 8] = true;
                        bg[4, 9] = true;

                        break;
                }
                for (int x = 1; x <= 4; x++)
                {
                    for (int y = 1; y <= 9; y++)
                    {
                        panel1.Controls.Add(new DigitalNumber() {
                            isfilled = bg[x, y],
                           
                            Top= y * 10,
                            Left=x*10+10*5*i,
                        }
                        );

                    }

                }
                
            }
            
        }

        private void CreateTable()
        {
            string[] headers = new string[] {
                 "Year",
                 "Bread Price (USD)",
                 "Gold Price (USD)",
                 "Exchange Rate",
                 "Gold Price in Selected Currency"
                 };
            for (int i = 0; i < headers.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = headers[i];
            }
            object[,] values = new object[foreCast.Count, headers.Length];
            int counter = 0;
            foreach (ForeCast f in foreCast)
            {
                values[counter, 0] = f.year;
                values[counter, 1] = f.gold;
                values[counter, 2] = f.bread;
                var currentrate = (from x in exchangeRates
                                   where x.Country == (CountyEnum)countrycombo.SelectedIndex+1 select x.countrycode).FirstOrDefault();
                values[counter, 3] = -1364 + 0.67 * f.year + 6.33 * currentrate;
  

                values[counter, 4] = "=(" + GetCell(counter + 2, 2)+"*"+purchaseAmount.Value+"*"+ GetCell(counter + 2, 4)+")";
                
                counter++;
            }
            xlSheet.get_Range(
             GetCell(2, 1),
             GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;

            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            headerRange.RowHeight = 40;
            headerRange.Interior.Color = Color.LightBlue;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            Excel.Range TableRange = xlSheet.get_Range(GetCell(2, 1), GetCell(counter + 1, headers.Length));
            TableRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            Excel.Range FirstColRange = xlSheet.get_Range(GetCell(2, 1), GetCell(counter + 1, 1));
            FirstColRange.Interior.Color = Color.LightYellow;
            FirstColRange.Font.Bold = true;

            Excel.Range LastColRange = xlSheet.get_Range(GetCell(2, headers.Length), GetCell(counter + 1, headers.Length));
            LastColRange.Interior.Color = Color.LightGreen;
            LastColRange.NumberFormat = "0.00";
        }

        private void CreateExcel()
        {
            try
            {
                // Excel elindítása és az applikáció objektum betöltése
                xlApp = new Excel.Application();

                // Új munkafüzet
                xlWB = xlApp.Workbooks.Add(Missing.Value);

                // Új munkalap
                xlSheet = xlWB.ActiveSheet;

                // Tábla létrehozása
                CreateTable();

                // Control átadása a felhasználónak
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex) // Hibakezelés a beépített hibaüzenettel
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                // Hiba esetén az Excel applikáció bezárása automatikusan
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }
        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;


        }
    }
}
