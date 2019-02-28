namespace CalorieCalculatorProyekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dishes", "Protein", c => c.Single(nullable: false));
            AlterColumn("dbo.Dishes", "Fat", c => c.Single(nullable: false));
            AlterColumn("dbo.Dishes", "Carbohydrate", c => c.Single(nullable: false));
            AlterColumn("dbo.Dishes", "Calorie", c => c.Single(nullable: false));
            AlterColumn("dbo.FoodProducts", "Protein", c => c.Single(nullable: false));
            AlterColumn("dbo.FoodProducts", "Fat", c => c.Single());
            AlterColumn("dbo.FoodProducts", "Carbohydrate", c => c.Single(nullable: false));
            AlterColumn("dbo.FoodProducts", "Natrium", c => c.Single(nullable: false));
            AlterColumn("dbo.FoodProducts", "Calcium", c => c.Single(nullable: false));
            AlterColumn("dbo.FoodProducts", "Potassium", c => c.Single(nullable: false));
            AlterColumn("dbo.FoodProducts", "Magnesium", c => c.Single(nullable: false));
            AlterColumn("dbo.FoodProducts", "Phosphor", c => c.Single(nullable: false));
            AlterColumn("dbo.FoodProducts", "Iron", c => c.Single(nullable: false));
            AlterColumn("dbo.FoodProducts", "Carotene", c => c.Single(nullable: false));
            AlterColumn("dbo.FoodProducts", "A", c => c.Single(nullable: false));
            AlterColumn("dbo.FoodProducts", "B1", c => c.Single());
            AlterColumn("dbo.FoodProducts", "B2", c => c.Single());
            AlterColumn("dbo.FoodProducts", "PP", c => c.Single(nullable: false));
            AlterColumn("dbo.FoodProducts", "C", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FoodProducts", "C", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.FoodProducts", "PP", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.FoodProducts", "B2", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.FoodProducts", "B1", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.FoodProducts", "A", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.FoodProducts", "Carotene", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.FoodProducts", "Iron", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.FoodProducts", "Phosphor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.FoodProducts", "Magnesium", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.FoodProducts", "Potassium", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.FoodProducts", "Calcium", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.FoodProducts", "Natrium", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.FoodProducts", "Carbohydrate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.FoodProducts", "Fat", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.FoodProducts", "Protein", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Dishes", "Calorie", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Dishes", "Carbohydrate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Dishes", "Fat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Dishes", "Protein", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
