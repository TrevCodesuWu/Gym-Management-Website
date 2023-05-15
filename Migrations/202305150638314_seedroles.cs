namespace Gym_Management_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedroles : DbMigration
    {
        public override void Up()
        {
            Sql(@"

                 INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name], [Address], [PhoneNo], [LibraryId]) VALUES (N'f2829230-c8a6-46ef-8f7b-20c2713906c1', N'Admin01@gmail.com', 0, N'AKMDOpHQemamIxDElHeJSkhvaB6kIIRvU8GJBeqK+Znf7F+2UvtQbU762SurstPeMQ==', N'831aa4f0-de23-4a8b-8bed-dd20ac7e9ab6', NULL, 0, 0, NULL, 1, 0, N'Admin01@gmail.com', N'Admin01', N'North wood drive', N'0937485948', N'c1b40d')
                 INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd2a06dc2-96d4-4f96-bb0d-d2992a90f4c9', N'AdminRole')
                 INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f2829230-c8a6-46ef-8f7b-20c2713906c1', N'd2a06dc2-96d4-4f96-bb0d-d2992a90f4c9')
");
        }
        
        public override void Down()
        {
        }
    }
}
