namespace Gym_Management_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class driverdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        driver_email = c.String(),
                        phone_num = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Drivers");
        }
    }
}
