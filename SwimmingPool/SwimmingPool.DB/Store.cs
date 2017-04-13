using SwimmingPool.Specification.Store;

namespace SwimmingPool.DB
{
    public class Store : IStore
    {
        public IOrderRepository OrderRepository { get; }
    }
}