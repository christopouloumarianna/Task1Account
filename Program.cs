using System;

namespace task_1_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account customer = new Account("Dimitris", 2000, 0);
            Console.WriteLine(customer);

            bool success = customer.Withdraw(200);
            if (success) Console.WriteLine(" Withdrawal successfull :)");

            else Console.WriteLine(" Withdrawal unsuccessfull :(");



            customer.Withdraw(200);
            Console.WriteLine(customer);

            customer.Withdraw(200);
            Console.WriteLine(customer);

            customer.Withdraw(2000);
            Console.WriteLine(customer);

            StoreAccount storeAccount = new StoreAccount("manos", 2000, 0, "ypokatastima", "deposit");
            Console.WriteLine(storeAccount);

            storeAccount.Withdraw(200);
        }
        class Account
        {
            const double depositLimit = 5000;
            string owner;
            double balance;
            int numberOfTransactions;

            public Account()
            {

            }
            public Account(string owner, double balance, int numberOfTransactions)
            {
                this.owner = owner;
                this.balance = balance;
                this.numberOfTransactions = numberOfTransactions;
            }
            public bool Withdraw(double amount)
            {
                numberOfTransactions++;

                if (amount > balance)
                {
                    return false;
                }
                balance -= amount;
                return true;

            }
            public bool Deposit(double amount)
            {
                numberOfTransactions++;
                if (amount > depositLimit)
                {
                    return false;
                }

                balance += amount;
                return true;

            }
            public override string ToString()
            {
                return "Owner=" + owner + "Balance=" + balance + "numberOfTransactions" + numberOfTransactions;
            }

        }

        class StoreAccount : Account
        {
            string storeName;
            string accountCategory;

            public StoreAccount()
            {

            }
            public StoreAccount(string owner, double balance, int numberOfTransactions, string storeName, string accountCategory) : base(owner, balance, numberOfTransactions)
            {
                this.storeName = storeName;
                this.accountCategory = accountCategory;
            }
            public override string ToString()
            {
                return base.ToString() + "storeName=" + storeName + "accountCategory";



            }
            public void changeCategory()
            {

            }
        }

    }
}

