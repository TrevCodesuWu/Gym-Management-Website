namespace Gym_Management_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imagefield : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GymProducts", "prod_image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.GymProducts", "prod_image");
        }
    }
}
