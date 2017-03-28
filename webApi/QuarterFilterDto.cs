using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApi
{
    public class QuarterFilterDto
    {
        public decimal RBOB { get; set; }
        public string FiscalQuarter { get; set; }
    }
}