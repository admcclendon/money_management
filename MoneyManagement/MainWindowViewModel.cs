using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagement
{
    public class MainWindowViewModel
    {
        public AccountCollection Accounts { get; set; }

        public MainWindowViewModel()
        {
            Accounts = new AccountCollection();
            Accounts.Add(new Account("Checking", 1234.56));
            Accounts.Add(new Account("Savings", 4321.45));
        }
    }
}
