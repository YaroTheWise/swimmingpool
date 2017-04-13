using System.Linq;
using System.Threading.Tasks;
using SwimmingPool.Specification;
using SwimmingPool.Specification.Store;

namespace SwimmingPool.DB.Repositories
{
    internal class OrderRepository : IOrderRepository
    {
        public IQueryable<Order> Query()
        {
            throw new System.NotImplementedException();
        }

        public Task Save(Order order)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int orderId)
        {
            throw new System.NotImplementedException();
        }
    }
}