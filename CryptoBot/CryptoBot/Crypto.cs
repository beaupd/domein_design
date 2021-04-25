using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoBot
{
    class Crypto : Coin
    {
        private string networkName;
        private double amount;

        public Crypto(string name, double amount, double worth, string networkName)
            : base(name, amount, worth)
        {
            this.networkName = networkName;
            this.amount = amount;
        }

        public string getNetworkName()
        {
            return this.networkName;
        }

        public string toString()
        {
            return $"{this.name} is on the {this.networkName} network and is worth {this.amount}";
        }
    }
}
