namespace CyrillicSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCoctailModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CoctailModels", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CoctailModels", "Email");
        }
    }
}
