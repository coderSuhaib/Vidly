namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertiesToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.s", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.s", "NumberInStock", c => c.Int(nullable: false));
            AddColumn("dbo.s", "DateAdded", c => c.DateTime(nullable: false));
            AlterColumn("dbo.s", "Name", c => c.String(nullable: false, maxLength: 225));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.s", "Name", c => c.String());
            DropColumn("dbo.s", "DateAdded");
            DropColumn("dbo.s", "NumberInStock");
            DropColumn("dbo.s", "ReleaseDate");
        }
    }
}
