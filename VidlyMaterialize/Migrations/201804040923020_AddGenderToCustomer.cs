namespace VidlyMaterialize.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenderToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "GenderId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "GenderId");
            AddForeignKey("dbo.Customers", "GenderId", "dbo.Genders", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "GenderId", "dbo.Genders");
            DropIndex("dbo.Customers", new[] { "GenderId" });
            DropColumn("dbo.Customers", "GenderId");
        }
    }
}
