namespace QLThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUYENNGANH")]
    public partial class CHUYENNGANH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUYENNGANH()
        {
            DAUSACH = new HashSet<DAUSACH>();
        }

        [Key]
        public int MaCN { get; set; }

        [StringLength(50)]
        public string TenCN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAUSACH> DAUSACH { get; set; }
    }
}
