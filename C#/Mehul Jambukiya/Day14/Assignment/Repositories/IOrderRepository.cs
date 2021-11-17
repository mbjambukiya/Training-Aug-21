using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day14_Assignmnt.Models;

namespace Day14_Assignmnt.Repositories
{
    public interface IOrderRepository
    {
        MyOrder PostOrder(MyOrder order);
    }
}
