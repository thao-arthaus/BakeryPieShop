using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryPieShop.Models
{
    public class MockPieData : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryData();
        public IEnumerable<Pie> AllPies => new List<Pie>
        {
            new Pie {
                    PieId=1,
                    Name="Strawberry Pie",
                    Price=15.95M,
                    ShortDescription="Lorem ipsum",
                    LongDescription="Lorem ipsum",
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                    ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                    IsPieOfTheWeek=false,
                    InStock = true,
                    Category = _categoryRepository.AllCategories.ToList()[0]
                },
                new Pie {
                    PieId=2,
                    Name="Cheese cake",
                    Price=18.95M,
                    ShortDescription="Lorem ipsum",
                    LongDescription="Lorem ipsum",
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                    ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                    IsPieOfTheWeek=false,
                    InStock = true,
                    Category = _categoryRepository.AllCategories.ToList()[1]
                },
                new Pie {
                    PieId=3,
                    Name="Rhubarb Pie",
                    Price=18.95M,
                    ShortDescription="Lorem ipsum",
                    LongDescription="Lorem ipsum",
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                    ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                    IsPieOfTheWeek=true,
                    InStock = true,
                    Category = _categoryRepository.AllCategories.ToList()[0]
                },
                new Pie {
                    PieId=4,
                    Name="Pumpkin Pie",
                    Price=18.95M,
                    ShortDescription="Lorem ipsum",
                    LongDescription="Lorem ipsum",
                    ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                    ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                    IsPieOfTheWeek=true,
                    InStock = true,
                    Category = _categoryRepository.AllCategories.ToList()[2]
                }
        };
        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId) {
            return AllPies.FirstOrDefault(pie => pie.PieId == pieId);
        }
    }
}
