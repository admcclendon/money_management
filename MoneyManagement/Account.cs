using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagement
{
    public class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account()
        {

        }

        public Account(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }
    }

    public class AccountCollection : List<Account>
    {

    }
}
