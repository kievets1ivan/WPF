using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Models
{
    public class Abonent
    {
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public Time SpokenTime { get; private set; }
        public Operator Operator { get; private set; }
        public decimal Costs { get; private set; }

        public Abonent(string name, string phoneNumber, Time time, Operator oper)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            SpokenTime = time;
            Operator = oper;
            Costs = SpokenTime.GetTime() * Operator.PricePerSec;
        }

        public override string ToString()
        {
            return (new StringBuilder().Append(Name).Append(Delimetr.delimetr)
                .Append(PhoneNumber).Append(Delimetr.delimetr).Append(SpokenTime.GetTime())
                .Append(Delimetr.delimetr).Append(Operator).Append(Delimetr.delimetr)
                .Append(Costs)).ToString();

        }

    }
}
