namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRental1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Rentals", name: "CustomerId", newName: "Customers_Id");
            RenameColumn(table: "dbo.Rentals", name: "MovieId", newName: "Movies_Id");
            RenameIndex(table: "dbo.Rentals", name: "IX_CustomerId", newName: "IX_Customers_Id");
            RenameIndex(table: "dbo.Rentals", name: "IX_MovieId", newName: "IX_Movies_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Rentals", name: "IX_Movies_Id", newName: "IX_MovieId");
            RenameIndex(table: "dbo.Rentals", name: "IX_Customers_Id", newName: "IX_CustomerId");
            RenameColumn(table: "dbo.Rentals", name: "Movies_Id", newName: "MovieId");
            RenameColumn(table: "dbo.Rentals", name: "Customers_Id", newName: "CustomerId");
        }
    }
}
