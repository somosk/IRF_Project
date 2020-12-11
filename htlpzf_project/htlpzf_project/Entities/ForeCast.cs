using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htlpzf_project.Entities
{
    public class ForeCast
    {
        public int _year;
        public double _gold;
        public double _bread;

        public int year {
            get { return _year; }
            set {
                year = value;
                
                
            } }

        /*_bread = -37.18 + 0.019 * _year;
                _gold = 9179 - 4.78 * _year + 1210.1 * _bread;*/

       public double bread {
            get { return Math.Round(-37.18 + 0.019 * year,2); }
            set {
                bread = value;

            }

        }
       // _year=((_bread+37.18)/0.019)
        
        public double gold
        {
            get { return Math.Round(9179 - 4.78 * year + 1210.1 * bread,2);
                
            }
            set
            {
                gold = value;
            }
        }
    }
}
