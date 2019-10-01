using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }

        public string AccountHolder { get; set; }

        public decimal Balance { get; set; }

        public BankAccount(string AccNum,string AccHold,decimal bal)
        {
            AccountNumber = AccNum;
            AccountHolder = AccHold;
            Balance = bal;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void WithDraw(decimal amount)
        {
            if (Balance >= amount)
                Balance -= amount;
        }

        public string GetAccountDetails()
        {
            return $"Account Number : {AccountNumber} \nAccount holder : {AccountHolder} \nAccount Balance: {Balance}";

        }

    }
}
