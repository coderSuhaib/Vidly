namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditDataTypeInGenreId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.s", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.s", new[] { "Genre_Id" });
            DropColumn("dbo.s", "GenreId");
            RenameColumn(table: "dbo.s", name: "Genre_Id", newName: "GenreId");
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.s", "GenreId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Genres", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Genres", "Id");
            CreateIndex("dbo.s", "GenreId");
            AddForeignKey("dbo.s", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.s", "GenreId", "dbo.Genres");
            DropIndex("dbo.s", new[] { "GenreId" });
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Genres", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.s", "GenreId", c => c.Int());
            AddPrimaryKey("dbo.Genres", "Id");
            RenameColumn(table: "dbo.s", name: "GenreId", newName: "Genre_Id");
            AddColumn("dbo.s", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.s", "Genre_Id");
            AddForeignKey("dbo.s", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
