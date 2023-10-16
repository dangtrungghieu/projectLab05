namespace QLThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIDOCGIA")]
    public partial class LOAIDOCGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIDOCGIA()
        {
            DOCGIA = new HashSet<DOCGIA>();
        }

        [Key]
        public int MaLoaiDG { get; set; }

        [StringLength(50)]
        public string TenLoaiDG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCGIA> DOCGIA { get; set; }
    }
}
