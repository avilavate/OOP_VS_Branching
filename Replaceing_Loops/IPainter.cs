using System;

namespace Replaceing_Loops
{
    interface IPainter
    {
        bool IsAvailable { get; set; }
        double Rate { get; set; }
        TimeSpan Speedpermetersq { get; set; }
        TimeSpan TimetoPaintArea(double sqMeters);
        double CostToPaintArea(double sqMeters);
    }
}
