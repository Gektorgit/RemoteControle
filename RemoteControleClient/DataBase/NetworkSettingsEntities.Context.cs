﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RemoteControleClient.DataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NettworkSettingsEntities : DbContext
    {
        public NettworkSettingsEntities()
            : base("name=NettworkSettingsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BannedProgramms> BannedProgramms { get; set; }
        public virtual DbSet<Configuration> Configuration { get; set; }
        public virtual DbSet<DaysOfWeek> DaysOfWeek { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
