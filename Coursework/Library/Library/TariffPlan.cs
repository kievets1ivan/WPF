using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class TariffPlan
    {
        public string Name { get; }
        public decimal PricePerSec { get; }

        public TariffPlan(string name, decimal pricePerSec)
        {
            Name = name;
            PricePerSec = pricePerSec;
        }

        public override string ToString()
        {
            return Name + " " + PricePerSec;
        }
    }
}
