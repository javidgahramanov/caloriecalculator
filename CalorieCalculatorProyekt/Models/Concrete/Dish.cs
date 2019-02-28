using CalorieCalculatorProyekt.Models.Interfaces;

namespace CalorieCalculatorProyekt.Models.Concrete
{
    public class Dish : IFoodItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Carbohydrate { get; set; }
        public int CategoryId { get; set; }
        public float Calorie { get; set; }
    }
}