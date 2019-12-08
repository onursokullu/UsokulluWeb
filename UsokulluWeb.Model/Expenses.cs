using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class Expenses : Base
    {
        [Required]
        public string ExpenseType { get; set; }
        [Required]
        public string ExpenseDescription { get; set; }
        [Required]
        public decimal Payment { get; set; }

        //navigation properties
        
    }
}
