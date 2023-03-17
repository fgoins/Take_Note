using Dapper;
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
    }
}
