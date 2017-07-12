using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            };

           var cheapestPainter= FindCheapestPainter(100, painters);
            Console.WriteLine(cheapestPainter.Rate);
            Console.ReadKey();
        }
        private static IPainter FindCheapestPainter(double sqMeters, IEnumerable<IPainter> painters)
        {
            //ToDo: Loop which we will replace:
            IPainter result = null;
            double cost = double.MaxValue;
            foreach (var painter in painters)
            {
                if (painter.IsAvailable)
                {
                    var newCost = painter.CostToPaintArea(sqMeters);
                    if (cost > newCost)
                    {
                        cost = newCost;
                        result = painter;
                    }
                }
            }
            //-------------------------------:
            return result;
        }
    }
}
