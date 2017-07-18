using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replacing_Null
{
    class Program
    {
        static void Main(string[] args)
        {
            var RepairGuarentee = new Guarantee(new DateTime(2016,1,1), TimeSpan.FromDays(30));
            var MoneyBackGurantee = new Guarantee(new DateTime(2016, 1, 1), TimeSpan.FromDays(10));
            var article = new SoldItem(MoneyBackGurantee, RepairGuarentee);

            //claim guarantees

            if (article.MoneyBackGuarantee.IsValid(DateTime.Now)) Console.WriteLine($"Moneyback Gurantee is valid");
            Console.WriteLine("Moneyback Gurantee is invalid");
            if (article.RepairGuarentee.IsValid(DateTime.Now)) Console.WriteLine($"Repair Guarentee Gurantee is valid");
            Console.WriteLine("Repair Gurantee is invalid");

            Console.Read();
        }
    }
}
