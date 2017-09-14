namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDataMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("delete from MembershipTypes");
            Sql("insert into MembershipTypes (Id,SignUpFree,DurationInMonths,DiscountRate,Name) values (1,0,0,0,'Pay as You Go')");
            Sql("insert into MembershipTypes (Id,SignUpFree,DurationInMonths,DiscountRate,Name) values (2,30,1,10,'Monthly')");
            Sql("insert into MembershipTypes (Id,SignUpFree,DurationInMonths,DiscountRate,Name) values (3,90,3,15,'Every 3 Months')");
            Sql("insert into MembershipTypes (Id,SignUpFree,DurationInMonths,DiscountRate,Name) values (4,300,12,20,'Yearly')");
        }
        
        public override void Down()
        {
        }
    }
}
