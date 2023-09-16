using System.Security.Principal;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("18347", 123850);

            Console.WriteLine(account.GetInfo() + "\n");

            WithdrawFromAccount(account, 123);

            WithdrawFromAccount(account, 123123123123);

            WithdrawFromAccount(account, -123123);

            TopUpAccount(account, 1231231.23);

            TopUpAccount(account, -123123.5);

            Console.WriteLine(account.GetInfo() + "\n");
        }

        private static void WithdrawFromAccount(BankAccount account, double withdrawSum)
        {
            try
            {
                account.Withdraw(withdrawSum);
                Console.WriteLine($"Successfully withdrew {withdrawSum}\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }

        }

        private static void TopUpAccount(BankAccount account, double topUpSum)
        {
            try
            {
                account.TopUp(topUpSum);
                Console.WriteLine($"Successfully topped up {topUpSum}\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }

        }
    }
}