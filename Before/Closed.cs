using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before
{
    class Closed : IFreezeable
    {
        public IFreezeable Close() => this;
        public IFreezeable Deposite(Action addToBalance) => this;
        public IFreezeable Freez() => this;
        public IFreezeable Holderverified() => this;
        public IFreezeable WithDraw(Action subtractFromBalance) => this;
    }
}
