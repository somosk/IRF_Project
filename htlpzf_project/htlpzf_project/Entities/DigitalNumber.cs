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
                _isfilled = value;
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
        public int sor { get { return _sor; } set {
                _sor = value;
                Left = _sor * 60 + 20; } }
        public int _oszlop;
        public int oszlop { get { return _oszlop; } set {
                _oszlop = value;
                Top = _oszlop * 60 + 20; } }
        public DigitalNumber()
        {
            BackColor = Color.LightGray;
            
            Height = 60;
            Width = 60;
            
            
           
        }
        
      }

    
}
