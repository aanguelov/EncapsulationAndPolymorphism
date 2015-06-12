namespace _02_BankOfKurtovoKonare
{
    class DepositAccount : BankAccounts, IWithdrawable
    {
        public DepositAccount(ICustomer customer, decimal balance, decimal monthlyInterestRate) 
            : base(customer, balance, monthlyInterestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest = base.CalculateInterest(months);
            if (this.Balance > 0 && this.Balance < 1000)
            {
                interest = 0;
            }
            return interest;
        }

        public void WithdrawMoney(decimal withdrawAmount)
        {
            this.Balance -= withdrawAmount;
        }

        //public override decimal CalculateInterest(int periodInMonths)
        //{
        //    decimal interest;

        //    if (0 < this.Balance && this.Balance < 1000)
        //    {
        //        interest = base.CalculateInterest(0);
        //    }
        //    else
        //    {
        //        interest = base.CalculateInterest(periodInMonths);
        //    }

        //    return interest;
        //}
    }
}
