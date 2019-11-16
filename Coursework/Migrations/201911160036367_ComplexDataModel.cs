namespace Coursework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ComplexDataModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Product", "GetSetSaleType_ID", "dbo.SaleType");
            DropIndex("dbo.Product", new[] { "GetSetSaleType_ID" });
            CreateTable(
                "dbo.Sale",
                c => new
                    {
                        sale_id = c.Int(nullable: false, identity: true),
                        type = c.String(),
                    })
                .PrimaryKey(t => t.sale_id);
            
            AddColumn("dbo.Product", "sale_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Product", "sale_id");
            AddForeignKey("dbo.Product", "sale_id", "dbo.Sale", "sale_id", cascadeDelete: true);
            DropColumn("dbo.Product", "TypeOfSale");
            DropColumn("dbo.Product", "GetSetSaleType_ID");
            DropTable("dbo.SaleType");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SaleType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        saleType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Product", "GetSetSaleType_ID", c => c.Int());
            AddColumn("dbo.Product", "TypeOfSale", c => c.String());
            DropForeignKey("dbo.Product", "sale_id", "dbo.Sale");
            DropIndex("dbo.Product", new[] { "sale_id" });
            DropColumn("dbo.Product", "sale_id");
            DropTable("dbo.Sale");
            CreateIndex("dbo.Product", "GetSetSaleType_ID");
            AddForeignKey("dbo.Product", "GetSetSaleType_ID", "dbo.SaleType", "ID");
        }
    }
}
