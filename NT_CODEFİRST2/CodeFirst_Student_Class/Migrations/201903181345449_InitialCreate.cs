namespace CodeFirst_Student_Class.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Class_",
                c => new
                    {
                        ClassId = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ClassId);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        TcKimlikID = c.Long(nullable: false, identity: true),
                        AdSoyad = c.String(nullable: false, maxLength: 80),
                        SınıfID = c.Int(nullable: false),
                        class__ClassId = c.Int(),
                    })
                .PrimaryKey(t => t.TcKimlikID)
                .ForeignKey("dbo.Class_", t => t.class__ClassId)
                .Index(t => t.class__ClassId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "class__ClassId", "dbo.Class_");
            DropIndex("dbo.Student", new[] { "class__ClassId" });
            DropTable("dbo.Student");
            DropTable("dbo.Class_");
        }
    }
}
