using System;

namespace Replacing_Null
{
    public interface IGuarantee
    {
        bool IsValid(DateTime ReportDate);
    }
}