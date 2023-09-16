namespace BankAccount
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        public double Balance { get; private set; }

        public BankAccount(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void TopUp(double topUpSum)
        {
            if(topUpSum < 0)
            {
                throw new ArgumentException("Cannot top up with negative number");
            }
            Balance += topUpSum;
        }

        public void Withdraw(double withdrawSum)
        {
            if(withdrawSum < 0 || withdrawSum > Balance)
            {
                throw new ArgumentException($"Cannot withdraw {withdrawSum} since it is negative or more than balance");
            }
            Balance -= withdrawSum;
        }

        public string GetInfo()
        {
            return ToString();
        }

        public override string ToString()
        {
            return $"Account number: {AccountNumber}\n" +
                $"Balance: {Balance}";
        }
    }
}
