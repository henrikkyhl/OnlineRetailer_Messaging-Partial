using System.Collections.Generic;
using SharedModels;

namespace OrderApi.Data
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> GetByCustomer(int customerId);
    }
}
