namespace ManageApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        PhoneNo = c.String(maxLength: 10),
                        Code = c.String(nullable: false, maxLength: 2),
                        CompanyPhoto = c.Binary(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Job = c.String(nullable: false, maxLength: 50),
                        MobileNo = c.String(maxLength: 10),
                        Email = c.String(nullable: false, maxLength: 50),
                        BirthDate = c.DateTime(),
                        CompanyID_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Companies", t => t.CompanyID_ID, cascadeDelete: true)
                .Index(t => t.CompanyID_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "CompanyID_ID", "dbo.Companies");
            DropIndex("dbo.Customers", new[] { "CompanyID_ID" });
            DropTable("dbo.Customers");
            DropTable("dbo.Companies");
        }
    }
}
