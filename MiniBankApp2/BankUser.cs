using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankApp2
{
    internal class BankUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; } = new Address();
        public Account BankAccount { get; set; }

        public BankUser(string email, string password)
        {
            Email = email;
            Password = password;
            //BankAccount = new Account();

        }
    }
}
