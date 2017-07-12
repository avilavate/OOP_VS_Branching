using System;

namespace Replaceing_Loops
{
    class ProportionalPainter : IPainter
    {
        public bool IsAvailable { get; set; }

        public double Rate { get; set; }
        public TimeSpan Speedpermetersq { get; set; }

        public ProportionalPainter(double rate, TimeSpan speedpermetersq, bool IsAvailable)
        {
            this.Rate = rate;
            this.Speedpermetersq = speedpermetersq;
            this.IsAvailable = IsAvailable;
        }
        public double CostToPaintArea(double sqMeters)
        {
            return sqMeters * Rate;
        }

        public TimeSpan TimetoPaintArea(double sqMeters)
        {
            var newHours = sqMeters * Speedpermetersq.Hours;
            return new TimeSpan(int.Parse(newHours.ToString()), 0, 0);

        }
    }
}
