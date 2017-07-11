using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before
{
    class Frozen : IFreezeable
    {
        public Action OnAccountUnFreez { get; set; }

        public Frozen(Action onAccountUnFreez)
        {
            this.OnAccountUnFreez = onAccountUnFreez;
        }
        public IFreezeable Freez() => this;

        public IFreezeable WithDraw(Action subtractFromBalance)
        {
            this.OnAccountUnFreez();
            subtractFromBalance();
            return new Active(this.OnAccountUnFreez);
        }

        public IFreezeable Deposite(Action addToBalance)
        {
            this.OnAccountUnFreez();
            addToBalance();
            return new Active(this.OnAccountUnFreez);
        }

        public IFreezeable Holderverified() => this;

        public IFreezeable Close() => new Closed();      
    }
}
