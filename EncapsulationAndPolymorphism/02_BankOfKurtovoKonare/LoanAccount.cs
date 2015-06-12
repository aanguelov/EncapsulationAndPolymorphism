using System;

namespace _02_BankOfKurtovoKonare
{
    class LoanAccount : BankAccounts
    {
        public LoanAccount(ICustomer customer, decimal balance, decimal monthlyInterestRate) 
            : base(customer, balance, monthlyInterestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            int interestMonths = 0;
            if (this.Customer.CustomerType == CustomerType.Company)
            {
                interestMonths = Math.Max(0, months - 2);
                return base.CalculateInterest(interestMonths);
            }
            else
            {
                interestMonths = Math.Max(0, months - 3);
                return base.CalculateInterest(interestMonths);
            }
        }
    }
}
