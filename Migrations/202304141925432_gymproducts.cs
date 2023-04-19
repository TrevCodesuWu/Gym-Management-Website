namespace Gym_Management_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gymproducts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GymProducts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        prod_name = c.String(nullable: false),
                        prod_price = c.Double(nullable: false),
                        prod_qty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GymProducts");
        }
    }
}
