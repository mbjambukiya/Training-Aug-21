using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategory
    {
        private readonly GetSkilledDbContext context;
        public CategoryRepository(GetSkilledDbContext context) : base(context)
        {
            this.context = context;
        }
        public override bool DeleteData(int categoryId)
        {
            var category = context.Categories.Find(categoryId);
            if (category != null && category.IsDeleted == false)
            {
                category.IsDeleted = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
