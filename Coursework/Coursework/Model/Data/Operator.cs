using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Models
{
    public class Operator
    {
        public TypeOperator TypeOperator { get; }
        public decimal PricePerSec { get; }

        //делегат по операторам киев = 30, вода = 32, лайф = 43
        public Operator(TypeOperator typeOperator, decimal pricePerSec)
        {
            TypeOperator = typeOperator;
            PricePerSec = pricePerSec;
        }

        public override string ToString()
        {
            return TypeOperator + " " + PricePerSec;
        }
    }

    
}
