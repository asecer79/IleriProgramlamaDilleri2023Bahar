using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
    public class BankAccount
    {
        public BankAccount()
        {
            AccountNumber = GenerateAccountNumber();
        }
        //instance properties
        public string? AccountNumber { get; set; }
        public decimal ? Balance { get; set; }

        //static field
        public static int _nextAccountNumber = 1;

        //instance method
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        //instance method
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        //static method
        private static string GenerateAccountNumber()
        {
            return (_nextAccountNumber++).ToString();
        }
    }
}
