namespace Fyp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                        Address = c.String(maxLength: 20),
                        City = c.String(maxLength: 20),
                        State = c.String(maxLength: 20),
                        Zip = c.String(maxLength: 20),
                        Doctor = c.String(maxLength: 20),
                        Diagnosis = c.String(maxLength: 20),
                        Medication = c.String(maxLength: 20),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.PatientId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Patients");
        }
    }
}
