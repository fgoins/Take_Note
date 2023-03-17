﻿using Dapper;
using System;
using System.Data;
using Take_Note.Models;

namespace Take_Note
{
    public class BudgetRepository : IBudgetRepository
    {
        private readonly IDbConnection _conn;

        public BudgetRepository(IDbConnection conn) 
        {
          _conn = conn;
        }
        public IEnumerable<Budget> GetAllBudgets()
        {
            return _conn.Query<Budget>("Select * From Budget");
        }

        public Budget GetBudget(int id)
        {
            return _conn.QuerySingle<Budget>("SELECT * FROM Budget WHERE ID = @id", new { id = id });
        }

        public void UpdateBudget(Budget budget)
        {
            _conn.Execute("UPDATE Budget SET Bill = @bill, Amount = @amount WHERE ID = @id",
              new { bill = budget.Bill, amount = budget.Amount, id = budget.ID });
        }
    }
}
