using System;

namespace Before
{
    class NotVerified : IFreezeable
    {
        public Action OnAccountUnFreez { get; private set; }
        public NotVerified(Action onAccountUnFreez)
        {
            this.OnAccountUnFreez = onAccountUnFreez;
        }

        public IFreezeable Deposite(Action addToBalance) => this;
        public IFreezeable WithDraw(Action subtractFromBalance) => this;

        public IFreezeable Freez() => this;
       

        public IFreezeable Holderverified()
        {
            return new Active(this.OnAccountUnFreez);
        }

        public IFreezeable Close() => new Closed();
      
    }
}
