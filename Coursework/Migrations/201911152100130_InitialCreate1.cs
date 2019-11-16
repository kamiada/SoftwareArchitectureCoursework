namespace Coursework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TypeOfSale = c.String(),
                        GetSetSaleType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SaleType", t => t.GetSetSaleType_ID)
                .Index(t => t.GetSetSaleType_ID);
            
            CreateTable(
                "dbo.SaleType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        saleType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "GetSetSaleType_ID", "dbo.SaleType");
            DropIndex("dbo.Product", new[] { "GetSetSaleType_ID" });
            DropTable("dbo.SaleType");
            DropTable("dbo.Product");
        }
    }
}
