namespace Coursework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testingReport : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Report",
                c => new
                    {
                        report_id = c.Int(nullable: false, identity: true),
                        customer_name = c.String(),
                        customer_surname = c.String(),
                        Date = c.DateTime(nullable: false),
                        product_name = c.String(),
                        product_quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.report_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Report");
        }
    }
}
