using System;

namespace Replacing_Null
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Note this implementation doesnt support following scenarios:
             *          1- We cannot create an article with no moneyback guarantee.
             *          2- We cannot create an article with no repair guarantee.
             *          3- Passing null to SoldItem constructor will also not solve above problems because:
             *                  a- Passing null will throw ArgumentNullException from SoldItem ctor
             *                  b- if we disable validation in SoldItem ctor than the client code (i.e. Main() method will have to test
             *                     for null before it makes a call to ISValid on SoldItem class
             *                     
             * Solution:
             * Implement null objects (VoidGuarentee)                     
             */
            var RepairGuarentee = new Guarantee(new DateTime(2016, 1, 1), TimeSpan.FromDays(1000));
            var MoneyBackGurantee = new Guarantee(new DateTime(2016, 1, 1), TimeSpan.FromDays(10));
            var article = new SoldItem(MoneyBackGurantee, RepairGuarentee);

            //claim guarantees

            if (article.MoneyBackGuarantee.IsValid(DateTime.Now)) Console.WriteLine($"Moneyback Gurantee is valid");
            Console.WriteLine("Moneyback Gurantee is invalid");
            if (article.RepairGuarentee.IsValid(DateTime.Now)) Console.WriteLine($"Repair Guarentee Gurantee is valid");
            Console.WriteLine("Repair Gurantee is invalid");
            Console.WriteLine();
            //Solution when we can create articles with no guarantee:

            var VoidRepairGuarentee = VoidGuarantee.Instance;
            var VoidMoneyBackGurantee = VoidGuarantee.Instance;

            var saleItem = new SoldItem(VoidMoneyBackGurantee, VoidMoneyBackGurantee);

            if (saleItem.MoneyBackGuarantee.IsValid(DateTime.Now)) Console.WriteLine($"Moneyback Gurantee is valid");
            Console.WriteLine("Moneyback Gurantee is invalid");
            if (saleItem.RepairGuarentee.IsValid(DateTime.Now)) Console.WriteLine($"Repair Guarentee Gurantee is valid");
            Console.WriteLine("Repair Gurantee is invalid");

            Console.Read();
        }
    }
}
