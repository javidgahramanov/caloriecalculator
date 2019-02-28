namespace CalorieCalculatorProyekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddActivityTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ActivityId = c.Int(nullable: false, identity: true),
                        ActivityName = c.String(nullable: false),
                        KkalMin = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ActivityId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Activities");
        }
    }
}
