using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AppQuanLyDanhBa.Model
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
            : base("name=AppDBContext")
        {
        }

        public virtual DbSet<LienLac> LienLacs { get; set; }
        public virtual DbSet<Nhom> Nhoms { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nhom>()
                .HasMany(e => e.LienLacs)
                .WithOptional(e => e.Nhom)
                .HasForeignKey(e => e.IDNhom);
        }
    }
}
