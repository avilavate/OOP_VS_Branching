using System;

namespace Before
{
    interface IAccountState
    {
        IAccountState Freez();
        IAccountState WithDraw(Action subtractFromBalance);
        IAccountState Deposite(Action addToBalance );
        IAccountState Holderverified();
        IAccountState Close();
    }
}
