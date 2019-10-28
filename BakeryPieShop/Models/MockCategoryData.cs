using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryPieShop.Models
{
    public class MockCategoryData : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
             new List<Category>
             {
                 new Category {CategoryId=1,CategoryName="Fruit pies",Description="Lorem Ipsum"},
                new Category {CategoryId=2,CategoryName="Cheese cakes",Description="Lorem Ipsum"},
                new Category {CategoryId=3,CategoryName="Seasonal pies",Description="Lorem Ipsum"}
             };
        
        
    }
}
