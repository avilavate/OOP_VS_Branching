using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before
{
    class Frozen : IAccountState
    {
        public Action OnAccountUnFreez { get; set; }

        public Frozen(Action onAccountUnFreez)
        {
            this.OnAccountUnFreez = onAccountUnFreez;
        }
        public IAccountState Freez() => this;

        public IAccountState WithDraw(Action subtractFromBalance)
        {
            this.OnAccountUnFreez();
            subtractFromBalance();
            return new Active(this.OnAccountUnFreez);
        }

        public IAccountState Deposite(Action addToBalance)
        {
            this.OnAccountUnFreez();
            addToBalance();
            return new Active(this.OnAccountUnFreez);
        }

        public IAccountState Holderverified() => this;

        public IAccountState Close() => new Closed();      
    }
}
