using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAcc = new Account(() => { });
            myAcc.HolderVerified();
            myAcc.Deposit(100);
            myAcc.Withdraw(18);
          //  myAcc.Close();
            myAcc.Freez();
            myAcc.Deposit(10);
            Console.WriteLine(myAcc.Balance);
        }
    }
}
