using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppVersta.Domain.Repositories
{
    public class OrdersItems : IOrdersItems
    {
        private readonly DBContext context;

        public OrdersItems(DBContext context)
        {
            this.context = context;
        }
        public void AddOreder(Order order)
        {
            if(order.id == default)
            {
                context.Entry(order).State = EntityState.Added;
            }
            else
            {
                context.Entry(order).State = EntityState.Modified;
            }
            //context.Entry(order);
            context.SaveChanges();
            //throw new NotImplementedException();
        }

        public IQueryable<Order> GetAllOrders()
        {
            return context.Orders;
            //throw new NotImplementedException();
        }
    }
}
