using System;

namespace Before
{
    interface IFreezeable
    {
        IFreezeable Freez();
        IFreezeable WithDraw(Action subtractFromBalance);
        IFreezeable Deposite(Action addToBalance );
        IFreezeable Holderverified();
        IFreezeable Close();
    }
}
