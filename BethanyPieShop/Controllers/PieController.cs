﻿using BethanyPieShop.Model;
using BethanyPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanyPieShop.Controllers
{
    public class PieController : Controller
    {
       private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
           // ViewBag.CurrentCategory = "Chease cakes";
           // return View(_pieRepository.AllPies);

            PieListViewModel pieListViewModel = new PieListViewModel( _pieRepository.AllPies, "Chease cakes");
            return View(pieListViewModel);
            
        }
    }
    
}
