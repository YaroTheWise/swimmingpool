using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SwimmingPool.Specification.Store
{
    public interface IStore
    {
        IOrderRepository OrderRepository { get; }

    }
}
