namespace CodeFirst_Student_Class.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YasEklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "Yas", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "Yas");
        }
    }
}
