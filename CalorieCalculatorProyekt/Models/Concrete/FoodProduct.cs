using CalorieCalculatorProyekt.Models.Interfaces;

namespace CalorieCalculatorProyekt.Models.Concrete
{
    public class FoodProduct : IFoodItems, IMineralItems, IVitamins
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Carbohydrate { get; set; }
        public float Natrium { get; set; }
        public float Calcium { get; set; }
        public float Potassium { get; set; }
        public float Magnesium { get; set; }
        public float Phosphor { get; set; }
        public float Iron { get; set; }
        public float Carotene { get; set; }
        public float A { get; set; }
        public float B1 { get; set; }
        public float B2 { get; set; }
        public float PP { get; set; }
        public float C { get; set; }
        public double Calorie { get; set; }
        public int CategoryId { get; set; }

    }
}