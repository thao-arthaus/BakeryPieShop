using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BakeryPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BakeryPieShop.Controllers
{
    public class PieController : Controller
    {
        //get pie+category data
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        //pie contrustor
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {

            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;

        }

        public IActionResult Index()
        {
            return View(_pieRepository.AllPies);
        }

    }
}