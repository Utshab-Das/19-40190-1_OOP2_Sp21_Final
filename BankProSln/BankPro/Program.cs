using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPro
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Account("Soumuya", "2021", 500000);
            var s1 = new Account("Athoy ", "2014", 4000000);
            p1.Transfer(57000, s1);
            p1.showAllTransactions();
            s1.showAllTransactions();
        }
    }
}
