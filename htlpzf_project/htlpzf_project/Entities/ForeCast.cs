using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htlpzf_project.Entities
{
    public class ForeCast
    {
        public int year { get; set; }

        public double _bread;
        public double bread {
            get { return _bread; }
            set {
                _bread = -37.18 + 0.019*year;

            }

        }

        public double _gold;
        public double gold
        {
            get { return _gold; }
            set
            {
                _gold = 9179 - 4.78 * year + 1210.1 * bread;
            }
        }
    }
}
