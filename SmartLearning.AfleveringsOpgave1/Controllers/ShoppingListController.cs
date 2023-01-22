using Microsoft.AspNetCore.Mvc;
using SmartLearning.AfleveringsOpgave1.Models;
using System.Collections.Generic;
using System.Linq;

namespace SmartLearning.AfleveringsOpgave1.Controllers
{
    public class ShoppingListController : Controller
    {
        private readonly ShoppingListDbContext _dbContext;

        public ShoppingListController(ShoppingListDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<ShoppingList> ShoppingLists = _dbContext.ShoppingLists.ToList();
            return View(ShoppingLists);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ShoppingList shoppingList)
        {
            int shoppingListId;
            
            if (_dbContext.ShoppingLists.Count() == 0)
            {
                shoppingListId = 1;
            }
            else
            {
                shoppingListId = _dbContext.ShoppingLists.Select(x => x.Id).Max() + 1;
            }

            shoppingList.Id = shoppingListId;
            _dbContext.ShoppingLists.Add(shoppingList);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
        
    }
}
