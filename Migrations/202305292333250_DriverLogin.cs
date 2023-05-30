namespace Gym_Management_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DriverLogin : DbMigration
    {
        public override void Up()
        {
            Sql(@"
SET IDENTITY_INSERT [dbo].[Drivers] ON
INSERT INTO [dbo].[Drivers] ([id], [driver_email], [phone_num]) VALUES (1, N'Marry11@gmail.com', N'0817843849')
INSERT INTO [dbo].[Drivers] ([id], [driver_email], [phone_num]) VALUES (2, N'Felix11@gmail.com', N'0928348578')
INSERT INTO [dbo].[Drivers] ([id], [driver_email], [phone_num]) VALUES (3, N'Thomas11@gmail.com', N'0732678374')
SET IDENTITY_INSERT [dbo].[Drivers] OFF
");

        }

        public override void Down()
        {
        }
    }
}
