using System;
using System.Collections.Generic;
using Take_Note.Models;

namespace Take_Note
{
    public interface IBudgetRepository
    {
        public IEnumerable<Budget> GetAllBudgets();
        public Budget GetBudget(int id);
        public void UpdateBudget(Budget budget);
    }
}
