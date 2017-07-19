using System;

namespace Replacing_Null
{
    public static class GuaranteeFactory
    {
        private static IGuarantee GenerateGuarantee(DateTime dateIssued, TimeSpan duration) => new Guarantee(dateIssued, duration);
        private static IGuarantee NoGuarantee() => VoidGuarantee.Instance;
        public static IGuarantee Factory(DateTime dateIssued, TimeSpan duration) => GenerateGuarantee(dateIssued, duration);
        public static IGuarantee Factory() => NoGuarantee();
    }
}
