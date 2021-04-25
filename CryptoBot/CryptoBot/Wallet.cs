using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoBot
{
    class Wallet
    {
        public List<Crypto> assets = new List<Crypto>();
        public Fiat currency;
        private string walletOwner;

        public Wallet(string walletOwner, Fiat fiat)
        {
            this.walletOwner = walletOwner;
            this.currency = fiat;
        }
        public void addAsset(Crypto asset)
        {
            this.assets.Add(asset);
            
        }
        public void addFiat(double fiat)
        {
            this.currency.amount += fiat;

        }

        public double getTotal()
        {
            double total = 0;
            foreach (Coin coin in assets)
            {
                total += coin.worth * coin.amount;
            }
            return total;
        }

        public string toString()
        {
            string returnString = "";
            foreach (Coin coin in assets)
            {
                returnString += $"Holding {coin.name}, total amount: {coin.amount}\n";
            }

            returnString += $"Fiat holdings {getTotal().ToString()}";
            return returnString;
        }
    }
}
