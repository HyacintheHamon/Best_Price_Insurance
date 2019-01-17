namespace InsurancePolicyApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        firstName = c.String(maxLength: 4000),
                        lastName = c.String(maxLength: 4000),
                        emailAddress = c.String(maxLength: 4000),
                        DOB = c.DateTime(nullable: false),
                        carYear = c.Int(nullable: false),
                        carMake = c.String(maxLength: 4000),
                        carModel = c.String(maxLength: 4000),
                        DUI = c.String(maxLength: 4000),
                        speedingTickets = c.Int(nullable: false),
                        fullCoverage = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
