namespace Project_mvc.Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addprovincetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Provinces");
        }
    }
}
