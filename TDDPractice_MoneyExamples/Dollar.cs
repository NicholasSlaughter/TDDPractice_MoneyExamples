using System;
using System.Collections.Generic;
using System.Text;

namespace TDDPractice_MoneyExamples
{
    public class Dollar
    {
        private int amount;
        public Dollar(int amount)
        {
            //TODO: implement constructor
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        public override bool Equals(Object obj)
        {
            Dollar dollar = (Dollar) obj;
            return amount == dollar.amount;
        }
    }
}
