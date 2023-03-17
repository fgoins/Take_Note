using System;

namespace Take_Note.Models
{
    public class BillType
    {
        public int ID { get; set; }
        public char Bill { get; set; }
        public decimal Amount { get; set; }
        public char DueDate { get; set; }
    }

}
