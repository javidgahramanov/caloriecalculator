namespace CalorieCalculatorProyekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryIdColumnToDishes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dishes", "CategoryId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Dishes", "CategoryId");
        }
    }
}
