﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gordeev_41.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Gordeev_PKS41Entities : DbContext
    {
        public Gordeev_PKS41Entities()
            : base("name=Gordeev_PKS41Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client_Table> Client_Table { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Good_Table> Good_Table { get; set; }
        public virtual DbSet<NewsItem> NewsItems { get; set; }
        public virtual DbSet<Order_Table> Order_Table { get; set; }
    }
}
