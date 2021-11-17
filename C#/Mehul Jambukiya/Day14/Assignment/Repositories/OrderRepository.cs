using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day14_Assignmnt.Models;

namespace Day14_Assignmnt.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ToyCompanyDbContext _context;
        public OrderRepository(ToyCompanyDbContext context)
        {
            _context = context;
        }
        public MyOrder PostOrder(MyOrder order)
        {
            int neworderId = _context.Orders.Count() + 1;
            _context.Orders.Add(new Orders()
            {
                AddressId = order.addressId
            });
            _context.Items.Add(new Items()
            {
                ToyId = order.toyId,
                Quantity = order.quantity,
                OrderId = neworderId
            });
            _context.SaveChanges();
            return order;
        }
    }
}
