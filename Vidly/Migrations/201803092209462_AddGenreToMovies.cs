namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreToMovies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 225),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.s", "GenreId", c => c.Byte(nullable: false));
            AddColumn("dbo.s", "Genre_Id", c => c.Int());
            CreateIndex("dbo.s", "Genre_Id");
            AddForeignKey("dbo.s", "Genre_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.s", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.s", new[] { "Genre_Id" });
            DropColumn("dbo.s", "Genre_Id");
            DropColumn("dbo.s", "GenreId");
            DropTable("dbo.Genres");
        }
    }
}
