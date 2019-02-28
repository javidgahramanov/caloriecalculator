using System.ComponentModel.DataAnnotations;

namespace CalorieCalculatorProyekt.Models.Concrete
{
    public class Category
    {
        [Key]
        public int  CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}