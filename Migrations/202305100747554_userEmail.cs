namespace Gym_Management_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "userEmail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "userEmail");
        }
    }
}
