﻿
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
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Create(Product product)
        {
            repository.CreateProduct(product);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(repository.GetById(id));
        }
        [HttpPost]
        public IActionResult Details(Product product)
        {
            repository.UpdateProduct(product);
            return RedirectToAction("List");
        }

       

        public IActionResult Delete(int id)
        {
            repository.DeleteProduct(id);
            return RedirectToAction("List");
        }
    }
}
