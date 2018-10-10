namespace ClothBazar.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialized2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "MyProperty", c => c.Int(nullable: false));
        }
    }
}
