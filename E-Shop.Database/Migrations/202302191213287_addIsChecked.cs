namespace E_Shop.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIsChecked : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "IsChecked", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "IsChecked");
        }
    }
}
