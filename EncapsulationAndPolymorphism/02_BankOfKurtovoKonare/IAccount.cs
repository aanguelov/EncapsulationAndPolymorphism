namespace _02_BankOfKurtovoKonare
{
    interface IAccount : IDepositable
    {
        ICustomer Customer { get; }

        decimal Balance { get; }

        decimal MonthlyInterestRate { get; }
    }
}
