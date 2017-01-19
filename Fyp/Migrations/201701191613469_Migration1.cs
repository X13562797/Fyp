namespace Fyp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "Name", c => c.String());
            AlterColumn("dbo.Patients", "Address", c => c.String());
            AlterColumn("dbo.Patients", "City", c => c.String());
            AlterColumn("dbo.Patients", "State", c => c.String());
            AlterColumn("dbo.Patients", "Zip", c => c.String());
            AlterColumn("dbo.Patients", "Doctor", c => c.String());
            AlterColumn("dbo.Patients", "Diagnosis", c => c.String());
            AlterColumn("dbo.Patients", "Medication", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "Medication", c => c.String(maxLength: 20));
            AlterColumn("dbo.Patients", "Diagnosis", c => c.String(maxLength: 20));
            AlterColumn("dbo.Patients", "Doctor", c => c.String(maxLength: 20));
            AlterColumn("dbo.Patients", "Zip", c => c.String(maxLength: 20));
            AlterColumn("dbo.Patients", "State", c => c.String(maxLength: 20));
            AlterColumn("dbo.Patients", "City", c => c.String(maxLength: 20));
            AlterColumn("dbo.Patients", "Address", c => c.String(maxLength: 20));
            AlterColumn("dbo.Patients", "Name", c => c.String(maxLength: 20));
        }
    }
}
