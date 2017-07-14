using System.Collections.Generic;
using System.Linq;

namespace Replaceing_Loops
{
    class Painters
    {
        public IEnumerable<IPainter> ContainedPainters { get; }

        public Painters(IEnumerable<IPainter> painters)
        {
            this.ContainedPainters = painters;
        }

        public Painters GetAvailable() => new Painters(this.ContainedPainters.Where(p => p.IsAvailable));
        public IPainter GetCheapestOne(double sqMeters) => this.ContainedPainters.MinValueFinder(p => p.CostToPaintArea(sqMeters));
        public IPainter GetFastestOne(double sqMeters) => this.ContainedPainters.MinValueFinder(p => p.TimetoPaintArea(sqMeters));
    }
}