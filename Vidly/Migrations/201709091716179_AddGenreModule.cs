namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreModule : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            Sql("insert into Genres(Id,Name) values (1,'Comedy')");
            Sql("insert into Genres(Id,Name) values (2,'Action')");
            Sql("insert into Genres(Id,Name) values (3,'Family')");
            Sql("insert into Genres(Id,Name) values (4,'Romance')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Genres");
        }
    }
}
