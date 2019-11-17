namespace Coursework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class display1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customer1", "bnpl_id_bnpl_id", "dbo.BuyNowPayLater");
            DropIndex("dbo.Customer1", new[] { "bnpl_id_bnpl_id" });
            DropTable("dbo.Customer1");
            DropTable("dbo.BuyNowPayLater");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BuyNowPayLater",
                c => new
                    {
                        bnpl_id = c.Int(nullable: false, identity: true),
                        status = c.String(),
                    })
                .PrimaryKey(t => t.bnpl_id);
            
            CreateTable(
                "dbo.Customer1",
                c => new
                    {
                        customer_id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Loyalty_Card = c.Boolean(nullable: false),
                        bnpl_id_bnpl_id = c.Int(),
                    })
                .PrimaryKey(t => t.customer_id);
            
            CreateIndex("dbo.Customer1", "bnpl_id_bnpl_id");
            AddForeignKey("dbo.Customer1", "bnpl_id_bnpl_id", "dbo.BuyNowPayLater", "bnpl_id");
        }
    }
}
