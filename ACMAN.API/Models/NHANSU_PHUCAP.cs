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
    
    public partial class NHANSU_PHUCAP
    {
        public long ID { get; set; }
        public long ID_NHANVIEN { get; set; }
        public Nullable<System.DateTime> NGAY_BD { get; set; }
        public string BAC_LUONG { get; set; }
        public Nullable<double> HESO { get; set; }
        public Nullable<double> LUONG_GOC { get; set; }
        public Nullable<double> LUONG_BH { get; set; }
        public Nullable<double> LUONG_TG { get; set; }
        public Nullable<double> GIAMTRU_TNCN { get; set; }
        public Nullable<double> PC_ANTRUA { get; set; }
        public Nullable<double> PC_XANG { get; set; }
        public Nullable<double> PC_DT { get; set; }
        public Nullable<double> PC_CHUCVU { get; set; }
        public Nullable<double> PC_KHAC { get; set; }
        public Nullable<double> PC_DACBIET { get; set; }
        public Nullable<double> LUONG_KHAC { get; set; }
        public Nullable<double> PC_XEPLOAI { get; set; }
        public Nullable<double> TONG_CONG { get; set; }
        public Nullable<bool> KHOA { get; set; }
        public Nullable<bool> TINH_BHXH { get; set; }
        public Nullable<bool> QUANDOC { get; set; }
        public Nullable<bool> TINHLUONG_COBAN { get; set; }
        public Nullable<bool> TINHTHUE_TNCN { get; set; }
    }
}
