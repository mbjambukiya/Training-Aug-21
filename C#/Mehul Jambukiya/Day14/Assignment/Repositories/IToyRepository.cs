using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day14_Assignmnt.Models;

namespace Day14_Assignmnt.Repositories
{
    public interface IToyRepository
    {
        IEnumerable<Toys> GetToys();
        Toys GetToy(int toyId);
    }
}
