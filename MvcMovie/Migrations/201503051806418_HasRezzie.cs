namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HasRezzie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "HasRezzie", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "HasRezzie");
        }
    }
}
