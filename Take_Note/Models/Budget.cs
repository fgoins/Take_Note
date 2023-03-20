using System;
namespace Take_Note.Models
{
    public class Budget
    {
        public Budget() 
        {
        }

        public int ID { get; set; }
        public string Bill { get; set; }
        public decimal Amount { get; set; }
        public  string DueDate { get; set; }
        public IEnumerable<BillType> billTypes { get; set; }

    }
}
