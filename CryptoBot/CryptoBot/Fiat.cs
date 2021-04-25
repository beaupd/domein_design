using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoBot
{
    class Fiat : Coin
    {
        private string regulator;

        public Fiat(string name, double amount, double worth, string regulator)
            : base(name, amount, worth)
        {
            this.regulator = regulator;
        }

        public string getRegulator()
        {
            return this.regulator;
        }

        public string toString()
        {
            return $"{this.name} is regulated by {this.regulator} and is worth {this.worth}";
        }
    }
}
