namespace NestOfHeart.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateteacher : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Tel", c => c.String());
            AddColumn("dbo.Teachers", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "Email");
            DropColumn("dbo.Teachers", "Tel");
        }
    }
}
