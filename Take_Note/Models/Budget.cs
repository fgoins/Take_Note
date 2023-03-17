using System;
namespace Take_Note.Models
{
    public class Budget
    {
        public Budget() 
        {
        }

        public int Id { get; set; }
        public char Bill { get; set; }
        public decimal Amount { get; set; }
        public  char DueDate { get; set; }

    }
}
