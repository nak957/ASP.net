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
    
    public partial class PtqKetqua
    {
        public string PtqMaSV { get; set; }
        public string PtqMaMH { get; set; }
        public Nullable<double> PtqDiem { get; set; }
    
        public virtual PtqSinhVien PtqSinhVien { get; set; }
        public virtual PtqMonHoc PtqMonHoc { get; set; }
    }
}
