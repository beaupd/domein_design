using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoBot
{
    public class Coin
    {
        public string name;
        public double amount;
        public double worth;
        public Coin(string nm, double amnt, double wrth)
        {
            this.name = nm;
            this.amount = amnt;
            this.worth = wrth;
        }
        public void addAmount(double amount)
        {
            this.amount += amount;
        }

        public bool subAmount(double amount)
        {
            if (this.amount - amount > 0)
            {
                this.amount -= amount;
                Console.WriteLine($"Sufficient balance");
                return true;
            }
            else
            {
                Console.WriteLine($"Insufficient balance");
                return false;
            }
        }
        
        public void newWorth(double worth)
        {
            this.worth = worth;
        }
        
    }
}
