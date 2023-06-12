using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Tracker
{
    class AccountCredentials<T1, T2, T3, T4>
    {
        public T4 AccountNumber { get; set; }
        public T3 Balance { get; set; }
        public T2 AccountType { get; set; }
        public T1 Name { get; set; }

    }
}
