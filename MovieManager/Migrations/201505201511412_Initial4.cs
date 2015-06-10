namespace MovieManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Self", c => c.String());
            DropColumn("dbo.Movies", "Asset");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Asset", c => c.String());
            DropColumn("dbo.Movies", "Self");
        }
    }
}
