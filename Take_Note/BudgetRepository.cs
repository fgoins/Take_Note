using Dapper;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Take_Note.Models;
using Microsoft.AspNetCore.Mvc;

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
            return _conn.Query<Budget>("SELECT * FROM Budget;");
        }

        public Budget GetBudget(int id)
        {
            return _conn.QuerySingle<Budget>("SELECT * FROM Budget WHERE ID = @id", new { id = id });
        }

        public void UpdateBudget(Budget budget)
        {
            _conn.Execute("UPDATE Budget SET Bill = @bill, Amount = @amount, DueDate =@duedate WHERE ID = @id;",
              new { bill = budget.Bill, amount = budget.Amount, duedate = budget.DueDate, id = budget.ID });
        }

        public void InsertBudget(Budget budgetToInsert)
        {
            _conn.Execute("INSERT INTO Budget (Bill, Amount, DueDate) VALUES (@bill, @amount, @duedate);",
            new { bill = budgetToInsert.Bill, amount = budgetToInsert.Amount, duedate= budgetToInsert.DueDate});
        }
        public IEnumerable<BillType> GetbillTypes()
        {
            return _conn.Query<BillType>("SELECT * FROM Budget;");

        }
        public Budget AssignBudget()
        {
            var billList = GetbillTypes();
            var budget = new Budget();
            budget.billTypes = billList;
            return budget;
        }

        public void DeleteBudget(Budget budget)
        {
            _conn.Execute("DELETE FROM Bill WHERE ID = @id;", new { id = budget.ID });
            _conn.Execute("DELETE FROM Amount WHERE ID = @id;", new { id = budget.ID });
            _conn.Execute("DELETE FROM DueDate WHERE ID = @id;", new { id = budget.ID });
        }
    }
}
