namespace SageHackbarthFinal.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GetStuffInDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "HouseNum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addresses", "HouseNum", c => c.String());
        }
    }
}
