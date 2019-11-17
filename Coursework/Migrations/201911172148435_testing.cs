namespace Coursework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testing : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReportAndAnalysis",
                c => new
                    {
                        report_and_analysis_ID = c.Int(nullable: false, identity: true),
                        store_name = c.String(),
                        Date = c.DateTime(nullable: false),
                        no_sold_items = c.Int(nullable: false),
                        no_of_customers = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.report_and_analysis_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReportAndAnalysis");
        }
    }
}
