﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SystemMngmt.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TheClinicEntities1 : DbContext
    {
        public TheClinicEntities1()
            : base("name=TheClinicEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<book_appointment> book_appointment { get; set; }
        public DbSet<Diagnostic> Diagnostics { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescribing> Prescribings { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Timework> Timeworks { get; set; }
        public DbSet<user_info> user_info { get; set; }
        public DbSet<Medicine_detail> Medicine_detail { get; set; }
    }
}
