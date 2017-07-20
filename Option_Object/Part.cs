using System;

namespace Option_Object
{
    class Part
    {
        public DateTime InstallmentDate { get; }
        public DateTime DefectDetectedOn { get; set; }

        public Part(DateTime installmentDate)
        {
            this.InstallmentDate = installmentDate;
        }

        public void MarkDefective(DateTime withDate)
        {
            Console.WriteLine("Called when circuit installed!");
            this.DefectDetectedOn = withDate;
        }
    }
}
