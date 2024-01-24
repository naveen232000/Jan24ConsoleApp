namespace Jan24ConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Cid = c.Int(nullable: false, identity: true),
                        CName = c.String(nullable: false, maxLength: 20),
                        City = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Cid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
