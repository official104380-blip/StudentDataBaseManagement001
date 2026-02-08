namespace StudentDataBaseManagement001.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        RollNumber = c.String(),
                        Course = c.String(),
                        Year = c.Int(nullable: false),
                        Gender = c.String(),
                        PhoneNumber = c.String(),
                        EmailAddress = c.String(),
                        Address = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
