namespace Fyp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Fyp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Fyp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Fyp.Models.ApplicationDbContext";
        }

        bool AddUserAndRole(Fyp.Models.ApplicationDbContext context)
        {
            IdentityResult ir;
            var rm = new RoleManager<IdentityRole>
                (new RoleStore<IdentityRole>(context));
            ir = rm.Create(new IdentityRole("canEdit"));
            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            var user = new ApplicationUser()
            {
                UserName = "kevinmoshey1@hotmail.com",
            };
            ir = um.Create(user, "w4vr8fwnmsmM!");
            if (ir.Succeeded == false)
                return ir.Succeeded;
            ir = um.AddToRole(user.Id, "canEdit");
            return ir.Succeeded;
        }

        protected override void Seed(Fyp.Models.ApplicationDbContext context)
        {
            AddUserAndRole(context);
            context.Patients.AddOrUpdate(p => p.Name,

        


        new Patient
        {
            Name = "Debra Garcia",
            Address = "1234 Main St",
            City = "Redmond",
            State = "WA",
            Zip = "10999",
            Doctor = "Johnson",
            Diagnosis = "Malaria",
            Medication = "Insulin",
            Email = "debra@example.com",
        },
         new Patient
         {
             Name = "Debra Garcia",
             Address = "1234 Main St",
             City = "Redmond",
             State = "WA",
             Zip = "10999",
             Doctor = "Johnson",
             Diagnosis = "Malaria",
             Medication = "Insulin",
             Email = "debra@example.com",
         },
         new Patient
         {
             Name = "Debra Garcia",
             Address = "1234 Main St",
             City = "Redmond",
             State = "WA",
             Zip = "10999",
             Doctor = "Johnson",
             Diagnosis = "Malaria",
             Medication = "Insulin",
             Email = "debra@example.com",
         },
         new Patient
         {
             Name = "Debra Garcia",
             Address = "1234 Main St",
             City = "Redmond",
             State = "WA",
             Zip = "10999",
             Doctor = "Johnson",
             Diagnosis = "Malaria",
             Medication = "Insulin",
             Email = "debra@example.com",
         },
         new Patient
         {
             Name = "Debra Garcia",
             Address = "1234 Main St",
             City = "Redmond",
             State = "WA",
             Zip = "10999",
             Doctor = "Johnson",
             Diagnosis = "Malaria",
             Medication = "Insulin",
             Email = "debra@example.com",
         }


         );
 }
    }
}
