using System;
using System.Text;

namespace _02_BankOfKurtovoKonare
{
    public abstract class BankAccounts : IAccount
    {
        private ICustomer customer;

        protected BankAccounts(ICustomer customer, decimal balance, decimal monthlyInterestRate)
        {
            this.Balance = balance;
            this.Customer = customer;
            this.MonthlyInterestRate = monthlyInterestRate;
        }

        public ICustomer Customer
        {
            get { return this.customer; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The bank account must have a customer.");
                }
                this.customer = value;
            }
        }
        public decimal Balance { get; protected set; }
        public decimal MonthlyInterestRate { get; private set; }

        public virtual decimal CalculateInterest(int months)
        {
            decimal interest = this.Balance*(this.MonthlyInterestRate*months + 1);
            return interest;
        }

        public void DepositMoney(decimal depositAmount)
        {
            this.Balance += depositAmount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Bank account holder: {0}", this.Customer.Name));
            sb.AppendLine(string.Format("Balance: {0}", this.Balance));
            return sb.ToString();
        }
    }
}
