using System;

namespace _02_BankOfKurtovoKonare
{
    class MortgageAccount : BankAccounts
    {
        public MortgageAccount(ICustomer customer, decimal balance, decimal monthlyInterestRate) 
            : base(customer, balance, monthlyInterestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer.CustomerType == CustomerType.Individual)
            {
                int interestMonths = Math.Max(0, months - 6);
                return base.CalculateInterest(interestMonths);
            }
            else
            {
                decimal interest;
                if (months <= 12)
                {
                    interest = this.Balance*((this.MonthlyInterestRate/2*months) + 1);
                }
                else
                {
                    interest = this.Balance * ((this.MonthlyInterestRate / 2 * 12) + 1);
                    interest += base.CalculateInterest(months - 12);
                }
                return interest;
            }
        }
    }
}
