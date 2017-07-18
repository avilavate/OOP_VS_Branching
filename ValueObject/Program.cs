using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = new MoneyAmount(10, "$");
            Console.WriteLine(money.ToString());
            MoneyAmount x = new MoneyAmount(2, "USD");
            MoneyAmount y = new MoneyAmount(2, "USD");
            HashSet<MoneyAmount> set = new HashSet<MoneyAmount>();
            set.Add(x);
            Console.WriteLine($"{x==y} {x!=y}");
            if (set.Contains(y))
                Console.WriteLine("Cannot add repeated value.");
            else
                set.Add(y);

            Console.WriteLine("Count = {0}", set.Count);

            Console.ReadLine();
        }
    }
}
