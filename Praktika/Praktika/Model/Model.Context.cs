﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Praktika.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Session1_XXEntities : DbContext
    {
        private static Session1_XXEntities _instance;
        public Session1_XXEntities()
            : base("name=Session1_XXEntities")
        {
        }
        public static Session1_XXEntities GetContext()
        {
            if (_instance == null)
                _instance = new Session1_XXEntities();
            return _instance;
                
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Offices> Offices { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
