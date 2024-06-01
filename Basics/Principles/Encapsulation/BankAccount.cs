
namespace Basics.Principles.Encapsulation
{
    public class BankAccount
    {
        private decimal _balance;
        //Here, BankAccount class, encapsulates the balance field 
        //avoids direct access to the field outside the class
        //controlling the behavior based on our requirements

        //Also, implementation details are hidden userd doesnot need to be understand the complex logic
        //Allowing user to focus on high level functionality

        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }

        public void Deposit(decimal balance)
        {
            if (balance < 0)
            {
                throw new ArgumentException("Deposit amount must be positive!");
            }
            _balance += balance;
        }

        public void Withdraw(decimal balance)
        {
            if (balance < 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive!");
            }

            if (balance > _balance)
            {
                throw new InvalidOperationException("Insufficient Balance!");
            }
            _balance -= balance;
        }

        public decimal GetBalance() { 
            return _balance;
        }
    }
}
