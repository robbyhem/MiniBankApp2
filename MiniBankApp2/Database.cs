using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankApp2
{
    internal class Database
    {
        public List<BankUser> BankUsers { get; set; }
        public Database()
        {
            BankUsers = new List<BankUser>()
            {
                new BankUser("ademola@thebulb.africa", "sdfghjk")
                {
                    FirstName = "Ademola",
                    LastName = "Balogun",
                    BankAccount = new Account(20000)
                },

                new BankUser("fortunate@thebulb.africa", "sdfghjk")
                {
                    FirstName = "Fortunate",
                    LastName = "Omonuwa",
                    BankAccount = new Account(1000)
                },

                new BankUser("samson@thebulb.africa", "sdfghjk")
                {
                    FirstName = "Samson",
                    LastName = "Dada",
                    BankAccount = new Account(15200)
                },

                new BankUser("chisom@thebulb.africa", "sdfghjk")
                {
                    FirstName = "Chisom",
                    LastName = "Iheme",
                    BankAccount = new Account(200000)
                },

                new BankUser("james@thebulb.africa", "sdfghjk")
                {
                    FirstName = "James",
                    LastName = "Olukanni",
                    BankAccount = new Account(20000)
                },

                new BankUser("emmanuel@thebulb.africa", "sdfghjk")
                {
                    FirstName = "Emmanuel",
                    LastName = "Ilivieda",
                    BankAccount = new Account(7000)
                },


            };
        }

    }
}
