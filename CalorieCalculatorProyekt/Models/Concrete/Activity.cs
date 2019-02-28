using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;

namespace CalorieCalculatorProyekt.Models.Concrete
{
    public class Activities
    {
        [Key]
        public int ActivityId { get; set; }
        [Required]

        public string ActivityName { get; set; }
        [Required]
        public double KkalMin { get; set; }

    }
}