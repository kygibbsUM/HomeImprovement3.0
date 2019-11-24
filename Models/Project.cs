using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HomeImprovement3._0.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public int Cost { get; set; }
    }
}
