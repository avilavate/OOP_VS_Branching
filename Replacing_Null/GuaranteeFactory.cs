using System;

namespace Replacing_Null
{
    public static class GuaranteeFactory
    {
        public static Guarantee GenerateGuarantee(DateTime dateIssued, TimeSpan duration) => new Guarantee(dateIssued, duration);
        public static VoidGuarantee NoGuarantee() => VoidGuarantee.Instance;
      
    }
}
