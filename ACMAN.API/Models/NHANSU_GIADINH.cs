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
    
    public partial class NHANSU_GIADINH
    {
        public long ID { get; set; }
        public long ID_NHANVIEN { get; set; }
        public string HO_TEN { get; set; }
        public Nullable<System.DateTime> NGAY_SINH { get; set; }
        public string QUAN_HE { get; set; }
        public string NGHE_NGHIEP { get; set; }
        public string TEL { get; set; }
        public string DIA_CHI { get; set; }
    }
}