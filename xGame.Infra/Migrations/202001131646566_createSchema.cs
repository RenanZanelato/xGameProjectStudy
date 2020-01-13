namespace xGame.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.player",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        firstName = c.String(nullable: false, maxLength: 50, unicode: false),
                        lastName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Password = c.String(nullable: false, maxLength: 100, unicode: false),
                        email = c.String(nullable: false, maxLength: 200, unicode: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.email, unique: true, name: "UK_PLAYER_EMAIL");
            
            CreateTable(
                "dbo.Type",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.player", "UK_PLAYER_EMAIL");
            DropTable("dbo.Type");
            DropTable("dbo.player");
        }
    }
}
