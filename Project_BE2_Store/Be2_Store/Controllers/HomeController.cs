using Be2_Store.Models;
using BusinessObject.BusinessObject;
using DataAccess.Reponsitory;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Be2_Store.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        private readonly IProductReponsitory _productRepository;
        private readonly ICategoryReponsitory _categoryRepository;

        public HomeController(IProductReponsitory productRepository, ICategoryReponsitory categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult HomePage()
        {
            var products = _productRepository.GetProducts();
            var categories = _categoryRepository.GetCategories();

            ViewBag.CategoryList = categories;
            return View(products);
        }

    }

}