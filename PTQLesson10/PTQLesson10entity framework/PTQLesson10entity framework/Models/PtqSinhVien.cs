//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PTQLesson10entity_framework.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PtqSinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PtqSinhVien()
        {
            this.PtqKetqua = new HashSet<PtqKetqua>();
        }
    
        public string PtqMaSV { get; set; }
        public string PtqHoSV { get; set; }
        public string PtqTenSV { get; set; }
        public Nullable<bool> PtqPhai { get; set; }
        public Nullable<System.DateTime> PtqNgaySinh { get; set; }
        public string PtqNoiSinh { get; set; }
        public string PtqMaKH { get; set; }
        public Nullable<double> PtqHocBong { get; set; }
        public Nullable<double> PtqDiemTrungBinh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PtqKetqua> PtqKetqua { get; set; }
        public virtual PtqKhoa PtqKhoa { get; set; }
    }
}