using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoBot
{
    class Bot
    {
        private Crypto crypto;
        private Fiat fiat;
        private string strategy;
        private double stakeAmount;
        private Wallet wallet;

        public Bot(Wallet wallet, Crypto crypto, Fiat fiat, string strat, double stakeAmount)
        {
            this.wallet = wallet;
            this.crypto = crypto;
            this.fiat = fiat;
            this.strategy = strat;
            this.stakeAmount = stakeAmount;
        }

        public void buy()
        {
            Crypto buying = this.wallet.assets[this.wallet.assets.IndexOf(crypto)]; 
            if (this.fiat.subAmount(this.stakeAmount))
            {
                double bought = buying.worth * this.stakeAmount;
                buying.addAmount(bought);
                Console.WriteLine($"Purchased {bought} for {this.stakeAmount} {this.crypto.name}");
            } else
            {
                Console.WriteLine($"Could not purchase");
            }
        }

        public void sell(double amount)
        {
            Crypto selling = this.wallet.assets[this.wallet.assets.IndexOf(crypto)];
            if (selling.subAmount(amount))
            {
                double sold = selling.worth * amount;
                selling.addAmount(sold);
                Console.WriteLine($"Sold {sold} for {amount} {this.crypto.name}");
            }
            else
            {
                Console.WriteLine($"Could not sell");
            }
        }

    }
}
