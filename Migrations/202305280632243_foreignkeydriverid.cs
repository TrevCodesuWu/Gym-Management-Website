namespace Gym_Management_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreignkeydriverid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "DriverId", c => c.Int());
            CreateIndex("dbo.Orders", "DriverId");
            AddForeignKey("dbo.Orders", "DriverId", "dbo.Drivers", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "DriverId", "dbo.Drivers");
            DropIndex("dbo.Orders", new[] { "DriverId" });
            DropColumn("dbo.Orders", "DriverId");
        }
    }
}
