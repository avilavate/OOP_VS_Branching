using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before
{
    class Closed : IAccountState
    {
        public IAccountState Close() => this;
        public IAccountState Deposite(Action addToBalance) => this;
        public IAccountState Freez() => this;
        public IAccountState Holderverified() => this;
        public IAccountState WithDraw(Action subtractFromBalance) => this;
    }
}
