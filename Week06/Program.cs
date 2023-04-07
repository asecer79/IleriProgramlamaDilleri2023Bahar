
namespace Week06
{

    class Program
    {
        static void Main(string[] args)
        {
            //standard instance creation
            //var human = new Human();
            //human.Age = 1;
            //human.FirstName = "Ahmet";
            //human.LastName = "Veli";

            //////object initializer

            //var human02 = new Human(39)
            //{
            //    FirstName = "Aydın",
            //    LastName = "Seçer"
            //};

            //var human1 = new Human();
            //var human2 = new Human("Aydın", "Seçer");
            //var human3 = new Human("Aydın2", "Seçer2", 39);

            //human3.Address.Add("Ankara");
            //human3[2] = "Amasya";
            //Console.WriteLine(human3[2]);

            BankAccount._nextAccountNumber = 101;
            BankAccount account1 = new BankAccount();
            Console.WriteLine(account1.AccountNumber);
            BankAccount account2 = new BankAccount();
            Console.WriteLine(account2.AccountNumber);
            BankAccount account3 = new BankAccount();
            Console.WriteLine(account3.AccountNumber);
            BankAccount account4 = new BankAccount();
            Console.WriteLine(account4.AccountNumber);
        }
    }
}

