using System;

namespace Before
{
    class Account
    {
        public double Balance { get; set; }
        private IAccountState State { get; set; }
        public Action OnAccountUnFreez { get; private set; }

        public Account(Action onAccountUnfreez)
        {
            this.OnAccountUnFreez = onAccountUnfreez;
            this.State = new NotVerified(this.OnAccountUnFreez);
        }
        public void Withdraw(double ammount) => this.State.WithDraw(() => { this.Balance = this.Balance - ammount; });
        public void Deposit(double ammount) => this.State.Deposite(() => { this.Balance += ammount; });
        public void HolderVerified() => this.State = this.State.Holderverified();
        public void Close() => this.State = this.State.Close();
        public void Freez() => this.State = this.State.Freez();
    }
}

/*
 * 
 * class Account
    {
        public double Balance { get; set; }
        //private bool isVarified { get; set; }
        //private bool isFrozen { get; set; }
        //private bool isClosed { get; set; }
        private IFreezeable State { get; set; }
        public Action OnAccountUnFreez { get; private set; }

        public Account(Action onAccountUnfreez)
        {
            this.OnAccountUnFreez = onAccountUnfreez;
            this.State = new NotVerified(this.OnAccountUnFreez);
        }

        public void Withdraw(double ammount)
        {
            //if (!this.isVarified) return;
            //if (this.isClosed) return;
            //if (this.isFrozen)
            //{
            //    this.isFrozen = false;
            //    this.OnAccountUnFreez();
            //}
            //this.Balance = this.Balance - ammount;
            this.State.WithDraw(() => { this.Balance=this.Balance - ammount; });

        }

        public void Deposit(double ammount)
        {
            //if (!this.isVarified) return;
            //if (this.isClosed) return;
            //if (this.isFrozen)
            //{
            //    this.isFrozen = false;
            //    this.OnAccountUnFreez();
            //}
            //this.Balance = this.Balance + ammount;

            this.State.Deposite(() => { this.Balance += ammount; });
        }

        public void HolderVerified()
        {
            this.State = this.State.Holderverified();
        }

        public void Close()
        {
            this.State = this.State.Close();
        }

        public void Freez()
        {
            this.State = this.State.Freez();
        }
    }
 * 
 */
