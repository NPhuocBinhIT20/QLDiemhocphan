using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLDiem.DAL
{
    public partial class QLDiemModel : DbContext
    {
        public QLDiemModel()
            : base("name=QLDiemModel")
        {
        }

        public virtual DbSet<HocPhan> HocPhans { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SinhVien>()
                .Property(e => e.IDStudent)
                .IsUnicode(false);
        }
    }
}
