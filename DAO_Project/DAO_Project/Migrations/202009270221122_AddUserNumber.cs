namespace DAO_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Number", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Number");
        }
    }
}
