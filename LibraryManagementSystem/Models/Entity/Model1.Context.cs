﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagementSystem.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbLibEntities : DbContext
    {
        public DbLibEntities()
            : base("name=DbLibEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblAuthor> TblAuthor { get; set; }
        public virtual DbSet<TblBook> TblBook { get; set; }
        public virtual DbSet<TblCategory> TblCategory { get; set; }
        public virtual DbSet<TblCezalar> TblCezalar { get; set; }
        public virtual DbSet<TblKasa> TblKasa { get; set; }
        public virtual DbSet<TblMembers> TblMembers { get; set; }
        public virtual DbSet<TblStaff> TblStaff { get; set; }
        public virtual DbSet<TblTransactions> TblTransactions { get; set; }
    }
}
