namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                insert dbo.AspNetUsers (Id, Email, EmailConfirmed, PasswordHash, SecurityStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEndDateUtc, LockoutEnabled, AccessFailedCount, UserName) values (N'5d211f37-7b58-44d5-93d8-60d2a3ccf311', N'admin@vidly.com', 0, N'AERD7Y1dXBCm3AlmJ3VecLrjNYddKKj21+tIiSFp87tajn8dL24GBoFXEfTm8SWmZA==', N'ef0357b7-8772-44ca-8c49-9c622e5bd917', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                insert dbo.AspNetUsers (Id, Email, EmailConfirmed, PasswordHash, SecurityStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEndDateUtc, LockoutEnabled, AccessFailedCount, UserName) values (N'b994f776-dc31-4d6f-a0fb-b6a6dc95aced', N'guest@vidly.com', 0, N'AEkxJWEcd0XAcsbu4DbmhYP267TMHjTr8XOZQE/4tmqMyaGIqoDJtVxx4wzuwg+bxQ==', N'99d8a511-92fd-4058-a51a-5d267ff075cd', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                insert dbo.AspNetRoles (Id, Name) values (N'2ae7d97a-b5f3-43b8-b0a0-7781642888c8', N'CanManageMovies')
                insert dbo.AspNetUserRoles (UserId, RoleId) values (N'5d211f37-7b58-44d5-93d8-60d2a3ccf311', N'2ae7d97a-b5f3-43b8-b0a0-7781642888c8')                
                ");
        }
        
        public override void Down()
        {
        }
    }
}
