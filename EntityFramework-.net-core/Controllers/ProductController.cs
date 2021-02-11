
using EntityFramework_.net_core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework_.net_core.Controllers
{
    public class ProductController : Controller 
    {
        private IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List() => View(repository.Products);
    }
}
