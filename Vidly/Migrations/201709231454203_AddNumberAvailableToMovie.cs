namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailableToMovie : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Rentals", name: "Customers_Id", newName: "Customer_Id");
            RenameColumn(table: "dbo.Rentals", name: "Movies_Id", newName: "Movie_Id");
            RenameIndex(table: "dbo.Rentals", name: "IX_Customers_Id", newName: "IX_Customer_Id");
            RenameIndex(table: "dbo.Rentals", name: "IX_Movies_Id", newName: "IX_Movie_Id");
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Byte(nullable: false));
            Sql("update dbo.Movies set NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailable");
            RenameIndex(table: "dbo.Rentals", name: "IX_Movie_Id", newName: "IX_Movies_Id");
            RenameIndex(table: "dbo.Rentals", name: "IX_Customer_Id", newName: "IX_Customers_Id");
            RenameColumn(table: "dbo.Rentals", name: "Movie_Id", newName: "Movies_Id");
            RenameColumn(table: "dbo.Rentals", name: "Customer_Id", newName: "Customers_Id");
        }
    }
}
