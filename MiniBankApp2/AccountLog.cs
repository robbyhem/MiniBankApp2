using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankApp2
{
    public class AccountLog
    {
        public string Name { get; set; }
        private static Account NotLoggedAccount { get; set; } = new Account();

        static AccountLog()
        {
            NotLoggedAccount.Name = "Not logged in";
        }

        private static int LoggedInAccountId { get; }

        static AccountLog()
        {
            LoggedInAccountId = 1234;
        }
    }
}
