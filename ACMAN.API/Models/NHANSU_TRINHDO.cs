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
    
    public partial class NHANSU_TRINHDO
    {
        public long ID { get; set; }
        public long ID_NHANVIEN { get; set; }
        public Nullable<System.DateTime> NGAY_BD { get; set; }
        public Nullable<System.DateTime> NGAY_KT { get; set; }
        public string TEN_TRUONG { get; set; }
        public string QUOC_GIA { get; set; }
        public string BANGCAP_CHUNGCHI { get; set; }
        public string LOAI_DAOTAO { get; set; }
        public string XEP_LOAI { get; set; }
        public string CHUYEN_NGANH { get; set; }
    }
}
