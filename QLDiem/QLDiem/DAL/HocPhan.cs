namespace QLDiem.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocPhan")]
    public partial class HocPhan
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string TenHocPhan { get; set; }

        public virtual List<SinhVien> SinhViens { get; set; }
    }
}
