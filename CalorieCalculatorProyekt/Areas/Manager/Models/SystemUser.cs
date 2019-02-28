using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CalorieCalculatorProyekt.Areas.Manager.Models
{
    public class SystemUser
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        [Required]

        public string UserName { get; set; }
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

    }
}