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
    
    public partial class KH_NCC_CT
    {
        public long ID { get; set; }
        public long ID_MA { get; set; }
        public string DAI_DIEN { get; set; }
        public string WEB { get; set; }
        public string FACEBOOK { get; set; }
        public string TK_NHANG { get; set; }
        public string TEN_NHANG { get; set; }
        public Nullable<long> TINH_TP { get; set; }
        public string SO_CMT { get; set; }
        public string NOICAP_CMT { get; set; }
        public Nullable<System.DateTime> NGAYCAP_CMT { get; set; }
        public Nullable<bool> GIOI_TINH { get; set; }
        public Nullable<System.DateTime> NGAY_SINH { get; set; }
        public Nullable<double> CHIET_KHAU { get; set; }
        public Nullable<byte> LEVEL_QUYTRINH { get; set; }
        public Nullable<long> ID_TRANG_THAI { get; set; }
    }
}
