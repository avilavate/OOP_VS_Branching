using System;
using System.Collections.Generic;
using System.Linq;

namespace Replaceing_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IPainter> painters = new List<IPainter> {
                new ProportionalPainter(10, new TimeSpan(2, 0, 0),true),
                new ProportionalPainter(14, new TimeSpan(1, 0, 0), true),
                new ProportionalPainter(8, new TimeSpan(3, 0, 0), false),
                 new ProportionalPainter(1, new TimeSpan(3, 0, 0), true),
            };

            // var cheapestPainter = FindCheapestPainter(100, painters);
            var cheapestPainter = GetCheapestPainter(100, new Painters(painters));
            Console.WriteLine(cheapestPainter.Rate);
            Console.ReadKey();
        }


        //Cleanest fastest Way of gettinfg cheapest, fastest, available painters ==> Composite pattern.
        private static IPainter GetFastestPainter(double sqMeters, Painters painters) => painters.GetAvailable().GetFastestOne(sqMeters);
        private static IPainter GetCheapestPainter(double sqMeters, Painters painters) => painters.GetAvailable().GetCheapestOne(sqMeters);
        private static Painters GetAllAvailablePainters(Painters painters) => painters.GetAvailable();


        private static IPainter FindCheapestPainter(double sqMeters, IEnumerable<IPainter> painters)
        {
            //ToDo: Loop which we will replace:
            //IPainter result = null;
            //double cost = double.MaxValue;
            //foreach (var painter in painters)
            //{
            //    if (painter.IsAvailable)
            //    {
            //        var newCost = painter.CostToPaintArea(sqMeters);
            //        if (cost > newCost)
            //        {
            //            cost = newCost;
            //            result = painter;
            //        }
            //    }
            //}
            //-------------------------------:

            //Using linq

            //return painters.
            //    Where(p => p.IsAvailable).
            //    OrderBy(p =>p.CostToPaintArea(sqMeters)).
            //    FirstOrDefault();


            //-------------------------------:

            //A more better Way:

            //var q = painters.
            //    Where(p => p.IsAvailable).
            //    Aggregate((IPainter)(null),
            //    (a, b) => a != null && a.CostToPaintArea(sqMeters) < b.CostToPaintArea(sqMeters) ? a : b
            //    );

            //return q;

            //-----------------:

            //The best way:
            //  painters = painters as IEnumerable<ProportionalPainter>;

            //var fastesPainter = painters.
            //       Where(p => p.IsAvailable).
            //       MinValueFinder<IPainter, TimeSpan>(p => p.TimetoPaintArea(sqMeters));

            //Console.WriteLine(fastesPainter.Speedpermetersq);

            return painters.
                   Where(p => p.IsAvailable).
                   MinValueFinder(p => p.CostToPaintArea(sqMeters));



            //-----------------:




            // return result;
        }
    }
}
