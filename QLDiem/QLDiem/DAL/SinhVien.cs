namespace QLDiem.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string IDStudent { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string DiemCC { get; set; }

        [StringLength(50)]
        public string DiemKT { get; set; }

        [StringLength(50)]
        public string DiemThi { get; set; }

        public long? IDHocPhan { get; set; }

        [ForeignKey("IDHocPhan")]

        public virtual HocPhan HocPhans { get; set; }
    }
}
