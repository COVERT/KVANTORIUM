﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KVANTORIUM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KVANTORIUMEntities1 : DbContext
    {
        public KVANTORIUMEntities1()
            : base("name=KVANTORIUMEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<KURS> KURS { get; set; }
        public virtual DbSet<PREPOD> PREPOD { get; set; }
        public virtual DbSet<USINIK> USINIK { get; set; }
    }
}