namespace Gym_Management_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class popDriverRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8afcc2f0-ff70-4628-a1b4-edb229bffe1c', N'DriverRole')

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name], [Address], [PhoneNo], [LibraryId]) VALUES (N'2fe62be6-914f-45f8-a494-4a2e8a26e8d8', N'Marry11@gmail.com', 0, N'AClgHgij+WuL10r02exRUB5WriW97bB0wJ+oPwnKtE8wDz7Fda1Wnn84EY9XTk702g==', N'6e4d3613-5b67-436c-bd4a-77f893bb9e9a', NULL, 0, 0, NULL, 1, 0, N'Marry11@gmail.com', N'Mary', N'23 department unit', N'0817843849', N'13b610')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name], [Address], [PhoneNo], [LibraryId]) VALUES (N'3ea0da0a-593e-4069-87c6-4818e81b05e4', N'Felix11@gmail.com', 0, N'ANOu837R7lD1XR/vZ2htyyTAm8L9wTg4rJzc/LQ1Ay0uA8NuShIDh1BAkTfc2hGE7g==', N'f406faff-561d-4841-9545-b45070f01a0e', NULL, 0, 0, NULL, 1, 0, N'Felix11@gmail.com', N'Felix', N'43 Unit ', N'0928348578', N'3032fc')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name], [Address], [PhoneNo], [LibraryId]) VALUES (N'47ebc5b0-e45f-4374-942b-007cd3cac8aa', N'Thomas11@gmail.com', 0, N'AFJkpdR81Pxe5T3G+VQ/1WZn4nJHqeCrow64IfpG6PH+9ABbgL44ZFb6SNB074sUrw==', N'15336ca1-f703-4a8b-890e-e545dcc6ba81', NULL, 0, 0, NULL, 1, 0, N'Thomas11@gmail.com', N'Thomas', N'12 greet street', N'0732678374', N'049bb3')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2fe62be6-914f-45f8-a494-4a2e8a26e8d8', N'8afcc2f0-ff70-4628-a1b4-edb229bffe1c')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3ea0da0a-593e-4069-87c6-4818e81b05e4', N'8afcc2f0-ff70-4628-a1b4-edb229bffe1c')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'47ebc5b0-e45f-4374-942b-007cd3cac8aa', N'8afcc2f0-ff70-4628-a1b4-edb229bffe1c')

");
        }
        
        public override void Down()
        {
        }
    }
}
