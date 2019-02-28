namespace CalorieCalculatorProyekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Protein = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Carbohydrate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Calorie = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FoodProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Protein = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fat = c.Decimal(precision: 18, scale: 2),
                        Carbohydrate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Natrium = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Calcium = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Potassium = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Magnesium = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Phosphor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iron = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Carotene = c.Decimal(nullable: false, precision: 18, scale: 2),
                        A = c.Decimal(nullable: false, precision: 18, scale: 2),
                        B1 = c.Decimal(precision: 18, scale: 2),
                        B2 = c.Decimal(precision: 18, scale: 2),
                        PP = c.Decimal(nullable: false, precision: 18, scale: 2),
                        C = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Calorie = c.Double(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FoodProducts");
            DropTable("dbo.Dishes");
            DropTable("dbo.Categories");
        }
    }
}
