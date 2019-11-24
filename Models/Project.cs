using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HomeImprovement3._0.Models
{
    public class Project
    {
        public int Id { get; set; }

        public int CreatedByID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        [Display(Name = "Created")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cost { get; set; }
    }
}
