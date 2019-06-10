using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Abonent
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public Time SpokenTime { get; set; }
        public Operator Operator { get; set; }
        public TariffPlan TariffPlan { get; set; }
        public decimal Costs { get; }

        public Abonent(string name, string phoneNumber, Time time, Operator oper, TariffPlan tplan)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            SpokenTime = time;
            Operator = oper;
            TariffPlan = tplan;
            Costs = SpokenTime.GetTime() * TariffPlan.PricePerSec;
        }

        public override string ToString()
        {
            return (new StringBuilder().Append(Name).Append(Delimetr.delimetr)
                .Append(PhoneNumber).Append(Delimetr.delimetr).Append(SpokenTime.GetTime())
                .Append(Delimetr.delimetr).Append((int)Operator).Append(Delimetr.delimetr)
                .Append(TariffPlan).Append(Delimetr.delimetr).Append(Costs)).ToString();

        }

    }
}
