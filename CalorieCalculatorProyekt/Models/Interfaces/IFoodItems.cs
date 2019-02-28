namespace CalorieCalculatorProyekt.Models.Interfaces
{
    public interface IFoodItems
    {
        float Protein { get; set; }
        float Fat { get; set; }
        float Carbohydrate { get; set; }
        int CategoryId { get; set; }

    }
}