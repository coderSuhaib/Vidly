namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectMembershipTypeNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Membershiptypes SET Name = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE Membershiptypes SET Name = 'Annually' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
