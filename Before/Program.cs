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
            myAcc.Close();
            myAcc.Deposit(10);
            Console.WriteLine(myAcc.Balance);
        }
    }
}
