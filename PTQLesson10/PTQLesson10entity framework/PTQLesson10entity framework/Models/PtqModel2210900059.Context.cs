﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PTQLesson10entity_framework.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PtqK22CNT2Lesson10DbEntities : DbContext
    {
        public PtqK22CNT2Lesson10DbEntities()
            : base("name=PtqK22CNT2Lesson10DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PtqKetqua> PtqKetqua { get; set; }
        public virtual DbSet<PtqKhoa> PtqKhoa { get; set; }
        public virtual DbSet<PtqMonHoc> PtqMonHoc { get; set; }
        public virtual DbSet<PtqSinhVien> PtqSinhVien { get; set; }
    }
}
