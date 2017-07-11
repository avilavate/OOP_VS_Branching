using System;

namespace Before
{
    class NotVerified : IAccountState
    {
        public Action OnAccountUnFreez { get; private set; }
        public NotVerified(Action onAccountUnFreez)
        {
            this.OnAccountUnFreez = onAccountUnFreez;
        }

        public IAccountState Deposite(Action addToBalance) => this;
        public IAccountState WithDraw(Action subtractFromBalance) => this;

        public IAccountState Freez() => this;
       

        public IAccountState Holderverified()
        {
            return new Active(this.OnAccountUnFreez);
        }

        public IAccountState Close() => new Closed();
      
    }
}
