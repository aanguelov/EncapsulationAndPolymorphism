using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_BankOfKurtovoKonare
{
    class BankOfKurtovoKonareMain
    {
        static void Main()
        {
            List<BankAccounts> bankAccounts = new List<BankAccounts>()
            {
                new DepositAccount(new Customer("Pesho", CustomerType.Individual), 100, 12),
                new MortgageAccount(new Customer("Ivanovi", CustomerType.Individual), -200, 16),
                new LoanAccount(new Customer("Petkov OOD", CustomerType.Company), 0, 8),
                new DepositAccount(new Customer("Favorit EOOD", CustomerType.Company), 100000, 5),
                new MortgageAccount(new Customer("Gosho", CustomerType.Individual), 0, 14),
                new LoanAccount(new Customer("SomeCompany", CustomerType.Company), 2500, 3)
            };

            var individualCustomers = bankAccounts
                .Where(a => a.Customer.CustomerType == CustomerType.Individual);

            foreach (var customer in individualCustomers)
            {
                Console.WriteLine(customer);
            }

            DepositAccount myAccount = new DepositAccount(new Customer("me", CustomerType.Individual), 1000, 10);
            //myAccount.WithdrawMoney(100);
            //Console.WriteLine(myAccount);
            Console.WriteLine(myAccount.CalculateInterest(1));
            myAccount.DepositMoney(1000);
            Console.WriteLine(myAccount.CalculateInterest(1));
        }
    }
}
