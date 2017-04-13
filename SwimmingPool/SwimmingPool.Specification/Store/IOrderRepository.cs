using System.Linq;
using System.Threading.Tasks;

namespace SwimmingPool.Specification.Store
{
    public interface IOrderRepository
    {
        IQueryable<Order> Query();
        Task Save(Order order);
        Task Delete(int orderId);

    }
}