using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineApi.Models
{
    public class Medicine
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The name field is required.")]
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        [RegularExpression(@"\d{2,2}/\d{2,2}/\d{4,4}",
        ErrorMessage = "Wrong Syntax.")]
        public string ExpDate { get; set; }
    }
}
