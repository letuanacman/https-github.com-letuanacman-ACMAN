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
    
    public partial class NHANSU_TL_HESO_LUONG
    {
        public long ID { get; set; }
        public long ID_NHOM { get; set; }
        public Nullable<int> STT { get; set; }
        public string NOI_DUNG { get; set; }
        public string KY_HIEU { get; set; }
        public Nullable<double> HE_SO { get; set; }
        public Nullable<double> LUONG_COBAN { get; set; }
        public Nullable<double> THANH_TIEN { get; set; }
        public string GHI_CHU { get; set; }
    }
}
