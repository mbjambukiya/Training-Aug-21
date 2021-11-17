using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day14_Assignmnt.Models;
using Day14_Assignmnt.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day14_Assignmnt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpPost()]
        public IActionResult PostOrder(MyOrder order)
        {
            try
            {
                return Ok(_orderRepository.PostOrder(order));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
