using System;

namespace _02_BankOfKurtovoKonare
{
    public class Customer : ICustomer
    {
        private string name;

        public Customer(string name, CustomerType customerType)
        {
            this.CustomerType = customerType;
            this.Name = name;
        }

        public CustomerType CustomerType { get; private set; }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                this.name = value;
            }
        }
    }
}
