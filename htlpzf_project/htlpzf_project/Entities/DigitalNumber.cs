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
        public bool _isfilled;
        public bool isfilled { get { return _isfilled; } set {
                if (_isfilled)
                {
                    Text = "X";
                    ForeColor = Color.DarkGreen;

                }
                else
                {
                    Text = "";
                }
            } }
        public int _sor;
        public int sor { get { return _sor; } set { Left = _sor * 60 + 20; } }
        public int _oszlop;
        public int oszlop { get { return _oszlop; } set { Top = _oszlop * 60 + 20; } }
        public DigitalNumber()
        {
            BackColor = Color.LightGray;
            
            Height = 60;
            Width = 60;
            
            
           
        }
        
      }

    
}
