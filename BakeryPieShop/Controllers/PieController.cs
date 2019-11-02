using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BakeryPieShop.Models;
using BakeryPieShop.ViewModels;
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
            PieListViewModel pieListViewModel = new PieListViewModel();
            //pass data from pie repository to viewModel
            pieListViewModel.Pies = _pieRepository.AllPies;
            pieListViewModel.CurrentCategory = "Cheese Cakes";
            return View(pieListViewModel);
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if(pie == null)
            {

                return NotFound();
            }
            else
            {
                return View(pie);
            }
            
        }

    }
}