using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Company
    {
        public string Ticker { get; set; }
        public string CompanyName { get; set; }
        public int Volume { get; set; }
        public bool Optionable { get; set; }
        public string Website { get; set; }

        public string CompanyFullInfo
        {
            get
            {
                return $"{ Ticker } | { CompanyName } | Volume: { Volume } | Optionalbe: { Optionable } | Website: { Website }";
            }
        }
    }
}
