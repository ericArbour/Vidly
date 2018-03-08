namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, MembershipTypeId) VALUES (1, 0, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, MembershipTypeId) VALUES (2, 30, 1, 10, 1)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, MembershipTypeId) VALUES (3, 90, 3, 15, 2)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, MembershipTypeId) VALUES (4, 300, 12, 20, 3)");
        }
        
        public override void Down()
        {
        }
    }
}
