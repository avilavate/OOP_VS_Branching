using System;

namespace Replacing_Null
{
    class VoidGuarantee : IGuarantee
    {
        public bool IsValid(DateTime ReportDate) => false;
    }
}
