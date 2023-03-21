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
        public List<string> Dates { get; set; } = new List<string> {"1st", "2nd", "3rd", "4th", "5th", "6th", "7th", "8th", "9th",
            "10th", "11th", "12th","13th", "14th","15th","16th","17th", "18th","19th","20th","21st","22nd","23rd","24th","25th","26th",
            "27th","28th","29th", "30th", "31st"};

    }
}
