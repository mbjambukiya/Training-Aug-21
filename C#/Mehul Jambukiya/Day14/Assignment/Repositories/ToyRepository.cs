using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day14_Assignmnt.Models;

namespace Day14_Assignmnt.Repositories
{
    public class ToyRepository : IToyRepository
    {
        private readonly ToyCompanyDbContext _context;
        public ToyRepository(ToyCompanyDbContext context)
        {
            _context = context;
        }
        public Toys GetToy(int toyId)
        {
            var toy = _context.Toys.Find(toyId);
            return toy;
        }

        public IEnumerable<Toys> GetToys()
        {
            return _context.Toys.ToList();
        }
    }
}
