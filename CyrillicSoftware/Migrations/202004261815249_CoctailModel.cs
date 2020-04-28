namespace CyrillicSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoctailModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoctailModels",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserSearch = c.String(),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CoctailModels");
        }
    }
}
