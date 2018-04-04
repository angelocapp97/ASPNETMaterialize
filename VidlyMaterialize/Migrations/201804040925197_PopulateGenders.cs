namespace VidlyMaterialize.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenders : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genders (Id, Name) VALUES (0, 'Male')");
            Sql("INSERT INTO Genders (Id, Name) VALUES (1, 'Female')");
            Sql("INSERT INTO Genders (Id, Name) VALUES (2, 'Other')");
        }
        
        public override void Down()
        {
        }
    }
}
