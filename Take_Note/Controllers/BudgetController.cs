﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Take_Note.Models;

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

        public IActionResult ViewBudget(int id)
        {
            var budget = repo.GetBudget(id);
            return View(budget);
        }

        public IActionResult UpdateBudget(int id)
        {
            Budget bill = repo.GetBudget(id);
            if (bill == null)
            {
                return View("BillNotFound");
            }
            return View(bill);
        }

        public IActionResult UpdateBudgetToDatabase(Budget budget)
        {
            repo.UpdateBudget(budget);

            return RedirectToAction("ViewBudget", new { id = budget.ID });
        }
    }
}
