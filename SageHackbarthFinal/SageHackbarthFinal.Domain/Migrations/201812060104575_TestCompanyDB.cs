namespace SageHackbarthFinal.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestCompanyDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Guid(nullable: false),
                        Street = c.String(),
                        HouseNum = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        Zip = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Guid(nullable: false),
                        Name = c.String(),
                        Username = c.String(),
                        DOB = c.DateTime(),
                        Address_AddressId = c.Guid(),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressId)
                .Index(t => t.Address_AddressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Address_AddressId", "dbo.Addresses");
            DropIndex("dbo.Customers", new[] { "Address_AddressId" });
            DropTable("dbo.Customers");
            DropTable("dbo.Addresses");
        }
    }
}
