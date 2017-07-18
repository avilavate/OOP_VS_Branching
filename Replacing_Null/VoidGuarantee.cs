using System;

namespace Replacing_Null
{
    class VoidGuarantee : IGuarantee
    {
        //Singleton design
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
    }
}
