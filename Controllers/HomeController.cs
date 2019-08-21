using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefDishes.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ChefDishes.Controllers
{
    public class HomeController : Controller
    {

        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            List<Chef> chefs = dbContext.Chefs
            .Include(chef => chef.ChefsDishes)
            .ToList();
            return View(chefs);
        }
        [HttpGet("Dishes")]
        public IActionResult Dishes()
        {
            List<Dish> dishes = dbContext.Dishes
            .Include(dish => dish.Creator)
            .ToList();
            return View(dishes);
        }
        [HttpGet("NewDish")]
        public IActionResult NewDish()
        {

            List<Chef> chefSelect = dbContext.Chefs.ToList();
            ViewBag.chefs = chefSelect;
            return View();
        }
        [HttpPost("AddDish")]
        public IActionResult AddDish(Dish dish)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(dish);
                dbContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            else
            {
                return RedirectToAction("NewDish");
            }
        }
        [HttpGet("NewChef")]
        public IActionResult NewChef()
        {
            return View();
        }

        [HttpPost("AddChef")]
        public IActionResult AddChef(Chef chef)
        {
            if (ModelState.IsValid){
                dbContext.Add(chef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("NewChef");
            }
        }


    }
}
