using System;

namespace Before
{
    internal class Active : IFreezeable
    {
        public Action OnAccountUnFreez { get; set; }
        public Active(Action onAccountUnFreez)
        {
            this.OnAccountUnFreez = onAccountUnFreez;
        }
        public IFreezeable Freez()
        {
            return new Frozen(this.OnAccountUnFreez);
        }

        public IFreezeable WithDraw(Action subtractFromBalance)
        {
            subtractFromBalance();
            return this;
        }

        public IFreezeable Deposite(Action addToBalance)
        {
            addToBalance();
            return this;
        }
        public IFreezeable Holderverified() => this;

        public IFreezeable Close() => new Closed();
      
    }
}