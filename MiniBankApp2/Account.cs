using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MiniBankApp2
{
    internal class Account
    {
        public string Number { get; set; }
        public string TransactionPin { get; set; }
        public decimal Balance { get; set; }

        public Account(decimal initialDeposit = 0)
        {
            Balance = 1000 + initialDeposit;
            //string acctNum = "";
            //string firstTwo = "07";
            //string nextSix = DateTime.Now.ToString("yyMMdd");
            //string lastTwo = new Random().Next(99).ToString().PadLeft(2, '0');
            //Number = acctNum;

            Number = $"07{DateTime.Now.ToString("yyMMdd")}{new Random().Next(99).ToString().PadLeft(2, '0')}";
            Console.WriteLine($"{Number}");

            transactions = new List<Transaction>();
        }

        public List<Transaction> transactions { get; set; }
        public string Name { get; internal set; }

        public virtual bool Withdrawl(decimal withdrawlAmount)
        {
            if (Balance < withdrawlAmount)
            {
                throw new ApplicationException("insufficient funds");
            }
            else if (withdrawlAmount <= 0)
            {
                throw new ApplicationException("invalid withdrawl amount");
            }

            Balance -= withdrawlAmount;

            Transaction newTransaction = new Transaction(withdrawlAmount);
            transactions.Add(newTransaction);

            return true;
        }
        
        
    }
}
