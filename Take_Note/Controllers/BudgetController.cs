using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Take_Note.Controllers
{
    public class BudgetController : Controller
    {
        private readonly IBudgetRepository repo;

        public BudgetController(IBudgetRepository repo)
        {
            this.repo = repo;
        }

        //Get Controller
        public IActionResult Index()
        {
            var Budget = repo.GetAllBudgets();
            return View(Budget);
        }
    }
}
