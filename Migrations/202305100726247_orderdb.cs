namespace Gym_Management_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        timeOrder = c.DateTime(nullable: false),
                        NameandQuant = c.String(nullable: false),
                        total = c.Double(nullable: false),
                        deliverystatus = c.String(),
                        tracking_num = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
