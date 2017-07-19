using System;

namespace Replacing_Null
{
    public class VoidGuarantee : IGuarantee
    {
        //Singleton design
        public VoidGuarantee(DateTime issuedate, TimeSpan duration)
        {
           
        }
        private static VoidGuarantee _instance;
        public static  VoidGuarantee Instance { get {
                if(_instance == null)
                {
                    _instance = new VoidGuarantee();
                    return _instance;
                }
                return _instance;
            }  }
        private VoidGuarantee()  {}
        public bool IsValid(DateTime ReportDate) => false;
        private VoidGuarantee Get() => Instance;
    }
}
