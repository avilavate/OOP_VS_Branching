using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replacing_Null
{
    class SoldItem
    {
        public IGuarantee MoneyBackGuarantee { get; }
        public IGuarantee RepairGuarentee { get; }

        public SoldItem(IGuarantee MoneyBackGuarantee, IGuarantee RepairGuarentee)
        {
            if (MoneyBackGuarantee == null) throw new ArgumentNullException("MoneyBackGuarantee can not be null");
            if (RepairGuarentee == null) throw new ArgumentNullException("RepairGuarentee can not be null");

            this.MoneyBackGuarantee = MoneyBackGuarantee;
            this.RepairGuarentee = RepairGuarentee;
        }
    }
}
