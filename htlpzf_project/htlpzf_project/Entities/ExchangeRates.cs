﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htlpzf_project.Entities
{
    public class ExchangeRates
    {
        public int year { get; set; }
        public CountyEnum Country { get; set; }
        public double rate { get; set; }
        public int countrycode;
    }
}
