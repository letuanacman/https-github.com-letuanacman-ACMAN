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
    
    public partial class NHANSU_LUONG
    {
        public long ID { get; set; }
        public long ID_NHANVIEN { get; set; }
        public long ID_HESO_PHUCAP { get; set; }
        public byte THANG { get; set; }
        public int NAM { get; set; }
        public Nullable<double> NGAY_CONG { get; set; }
        public Nullable<double> NGAYCONG_QD { get; set; }
        public Nullable<double> GIO_CONG { get; set; }
        public Nullable<double> TIEN_SANPHAM { get; set; }
        public Nullable<double> TIEN_DOANHSO { get; set; }
        public Nullable<double> TIEN_LAMTHEM { get; set; }
        public Nullable<double> TONG_CONG { get; set; }
        public Nullable<double> TIEN_BHXH_YT { get; set; }
        public Nullable<double> TIEN_THUE_TNCN { get; set; }
        public Nullable<double> TIEN_TAM_UNG { get; set; }
        public Nullable<double> TIEN_GIAMTRU_PHAT { get; set; }
        public Nullable<double> TONG_TT { get; set; }
        public Nullable<bool> KHOA { get; set; }
        public string GHI_CHU { get; set; }
    }
}