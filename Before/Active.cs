using System;

namespace Before
{
    internal class Active : IAccountState
    {
        public Action OnAccountUnFreez { get; set; }
        public Active(Action onAccountUnFreez) { this.OnAccountUnFreez = onAccountUnFreez; }
        public IAccountState Freez() => new Frozen(this.OnAccountUnFreez);
        public IAccountState WithDraw(Action subtractFromBalance)
        {
            subtractFromBalance();
            return this;
        }
        public IAccountState Deposite(Action addToBalance)
        {
            addToBalance();
            return this;
        }
        public IAccountState Holderverified() => this;
        public IAccountState Close() => new Closed();
    }
}