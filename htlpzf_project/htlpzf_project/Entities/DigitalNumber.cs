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
       
        public DigitalNumber()
        {

            //Text = hely.ToString();
            Height = 10;
            Width = 10;
            
            
           
        }
        
      }

    
}
