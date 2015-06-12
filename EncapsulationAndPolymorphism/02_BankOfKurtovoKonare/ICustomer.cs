namespace _02_BankOfKurtovoKonare
{
    public interface ICustomer
    {
        CustomerType CustomerType { get; }

        string Name { get; }
    }
}
