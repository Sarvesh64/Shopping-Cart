using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.Data.Interfaces;
using Website.Data.Models;

namespace Website.Data.Mocks
{
    public class MockCategoryRepository:ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                     {
                         new Category { CategoryName = "Men", Description = "All men products" },
                         new Category { CategoryName = "Women", Description = "All women products" },
                         new Category { CategoryName = "Kids", Description = "All kids products" }
                     };
            }
        }
    }
}
