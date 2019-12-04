using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class Expenses : Base
    {
        public string ExpenseType { get; set; }
        public string ExpenseDescription { get; set; }
        public decimal Payment { get; set; }

        //navigation properties
        
    }
}
