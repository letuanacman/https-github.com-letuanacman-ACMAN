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
    
    public partial class THIETLAP_KYHIEU_TAIKHOAN
    {
        public long ID { get; set; }
        public Nullable<int> VI_TRI { get; set; }
        public string TK_NO { get; set; }
        public string TK_CO { get; set; }
        public string KY_HIEU { get; set; }
        public Nullable<byte> DO_DAI { get; set; }
        public Nullable<byte> LOAI_KYHIEU { get; set; }
        public string UU_TIEN { get; set; }
        public string GHI_CHU { get; set; }
    }
}