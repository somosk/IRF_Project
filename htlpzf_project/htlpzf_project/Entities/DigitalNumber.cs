using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace htlpzf_project.Entities
{
    public class DigitalNumber: Label
    {
        public int _hely;
        
        public int hely { get { return _hely; } set { _hely = value; } }
        
        public bool _isfilled;
        public bool isfilled { get { return _isfilled; } set {
                _isfilled = value;
                if (_isfilled)
                {
                    //Text = "X";
                    // ForeColor = Color.DarkGreen;
                    BackColor = Color.DarkGreen;
                }
                else
                {
                    //Text = "";
                    BackColor = Color.LightGray;
                }
            } }
        public int _sor;
        public int sor { get { return _sor; } set {
                _sor = value;
                /*Left = _sor * 10+_hely*10*5 ;*/ } }
        public int _oszlop;
        public int oszlop { get { return _oszlop; } set {
                _oszlop = value;
               /* Top = _oszlop * 10 ;*/ } }
        public DigitalNumber()
        {

            //Text = hely.ToString();
            Height = 10;
            Width = 10;
            
            
           
        }
        
      }

    
}
