//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACMAN.API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOADON_QUYETDINH
    {
        public long ID { get; set; }
        public long ID_MAU_HD { get; set; }
        public string SO_QD { get; set; }
        public Nullable<System.DateTime> NGAY_KY { get; set; }
        public Nullable<System.DateTime> NGAY_APDUNG { get; set; }
        public Nullable<bool> SU_DUNG { get; set; }
    }
}