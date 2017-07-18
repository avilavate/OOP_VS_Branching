using System;

namespace Replacing_Null
{
    public class Guarantee : IGuarantee
    {
        public DateTime DateIssued { get; }
        public TimeSpan Duration { get;  }

        public Guarantee(DateTime dateIssued, TimeSpan duration)
        {
            this.DateIssued = dateIssued;
            this.Duration = duration;
        }

        public bool IsValid(DateTime ReportDate) => ReportDate < DateIssued + Duration;
    }
}
