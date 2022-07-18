using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppVersta.Domain.Repositories
{
    public interface IOrdersItems
    {
        IQueryable<Order> GetAllOrders();
        void AddOreder(Order order);
    }
}
