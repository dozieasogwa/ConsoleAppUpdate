namespace ConsoleAppUpdate
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            Wallet wallet = new Wallet();
            wallet.Add(new Money() { amount = 1 });
            wallet.Add(new Money() { amount = 5 });
            wallet.Add(new Money() { amount = 10 });
            wallet.Add(new Money() { amount = 20 });
            wallet.Add(new Money() { amount = 50 });
            wallet.Add(new Money() { amount = 100 });

            foreach (Money money in wallet)
            {
                Console.WriteLine("Bills... "  + money.amount);
            }
        }
    }
}
