using System;

namespace CryptoBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Fiat Euro = new Fiat("Euro", 0.0, 1, "European National banks");
            Crypto Bitcoin = new Crypto("Bitcoin", 0, 50000, "Bitcoin Network");
            Crypto Ethereum = new Crypto("Ethereum", 0, 1800, "ERC-20");

            Wallet myWallet = new Wallet("Beau Dekker", Euro);

            myWallet.addFiat(10000);
            myWallet.addAsset(Bitcoin);
            myWallet.addAsset(Ethereum);

            Console.WriteLine(myWallet.toString());

            Bot bot = new Bot(myWallet, Ethereum, Euro, "Momentum 4MA with trailstop", 100);
            bot.buy();
            bot.buy();

            Ethereum.newWorth(2000);

            bot.sell(200);

            Console.WriteLine(myWallet.toString());
        }
    }
}
