namespace Gym_Management_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingdbimages : DbMigration
    {
        public override void Up()
        {
            Sql(@"
SET IDENTITY_INSERT [dbo].[GymProducts] ON
INSERT INTO [dbo].[GymProducts] ([id], [prod_name], [prod_price], [prod_qty], [prod_image]) VALUES (10, N'Serious Mass 2.25kg', 900, 19, N'https://www.byclue.com/wp-content/uploads/2019/06/1-190.jpg')
INSERT INTO [dbo].[GymProducts] ([id], [prod_name], [prod_price], [prod_qty], [prod_image]) VALUES (11, N'Gold  Whey 0.9kg', 1300, 23, N'https://th.bing.com/th/id/R.ae25b73aa7aa56dcd12ae0e9678d1d7a?rik=lHgb3IYcLefD7A&pid=ImgRaw&r=0')
INSERT INTO [dbo].[GymProducts] ([id], [prod_name], [prod_price], [prod_qty], [prod_image]) VALUES (12, N'MS - Weight Gainer 0.2kg', 300, 10, N'https://th.bing.com/th/id/R.094b5f3d941f6d3bc5573cff9e312725?rik=4MevGci6coI4nA&pid=ImgRaw&r=0')
INSERT INTO [dbo].[GymProducts] ([id], [prod_name], [prod_price], [prod_qty], [prod_image]) VALUES (13, N'EZ Weight loss pills 0.3kg', 600, 50, N'https://th.bing.com/th/id/R.99158d5202e427ce5ecff8d9b69907a2?rik=RE9fMmgKpyYzzA&pid=ImgRaw&r=0')
INSERT INTO [dbo].[GymProducts] ([id], [prod_name], [prod_price], [prod_qty], [prod_image]) VALUES (14, N'USN - Diet fuel 2kg', 350, 40, N'https://storefeederimages.blob.core.windows.net/elitesupplements/Products/78ff9b6c-e07a-4c29-a11e-a1667091bef0/Full/ubuqv30b0yh.jpg')
INSERT INTO [dbo].[GymProducts] ([id], [prod_name], [prod_price], [prod_qty], [prod_image]) VALUES (15, N'Unaltered - Belly Burner 1kg', 400, 10, N'https://th.bing.com/th/id/R.eddea51ba002e84b9f46b4627262ba4a?rik=t6jnWpQhFrVPhw&pid=ImgRaw&r=0')
INSERT INTO [dbo].[GymProducts] ([id], [prod_name], [prod_price], [prod_qty], [prod_image]) VALUES (16, N'Nutrarise - Extreme Fat burn 200g', 800, 20, N'https://th.bing.com/th/id/R.60116d20df1c78c5a1b59d38f9f27b84?rik=CzIsyHKwtNNPcA&riu=http%3a%2f%2fecx.images-amazon.com%2fimages%2fI%2f917iEZXqO2L._SL1500_.jpg&ehk=9To2953mFee9xt0YTpmyMMlRZRRDY2Niv2cUFpXtVzo%3d&risl=&pid=ImgRaw&r=0')
INSERT INTO [dbo].[GymProducts] ([id], [prod_name], [prod_price], [prod_qty], [prod_image]) VALUES (17, N'Xzen Energy 500g', 300, 20, N'https://i5.walmartimages.com/asr/3865d782-7b12-4fdb-8429-3330db0cf20b.7b95e4fcfe1c5db1602147e6bbd39ee6.jpeg')
INSERT INTO [dbo].[GymProducts] ([id], [prod_name], [prod_price], [prod_qty], [prod_image]) VALUES (18, N'Muscle Milk Protein 907g', 550, 40, N'https://th.bing.com/th/id/R.cd651f0ad23f38b17f0bf0d6183c321a?rik=G9S7RXMxRtmQDA&pid=ImgRaw&r=0')
INSERT INTO [dbo].[GymProducts] ([id], [prod_name], [prod_price], [prod_qty], [prod_image]) VALUES (19, N'Creatine Powder 250g', 700, 15, N'https://th.bing.com/th/id/OIP.Xwd5jo02AlOGYlj36LZbIgHaHa?pid=ImgDet&w=600&h=600&rs=1')
SET IDENTITY_INSERT [dbo].[GymProducts] OFF

               ");
        }
        
        public override void Down()
        {
        }
    }
}
