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
    
    public partial class NHANSU_CHAMCONG_GIO
    {
        public long ID { get; set; }
        public long ID_NHANVIEN { get; set; }
        public byte THANG { get; set; }
        public int NAM { get; set; }
        public string MA_CA_LV { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public string GIO_VAO { get; set; }
        public string GIO_RA { get; set; }
        public string DI_MUON { get; set; }
        public string VE_SOM { get; set; }
        public Nullable<double> TONG_TG { get; set; }
        public Nullable<double> TONG_GIO { get; set; }
        public Nullable<double> GIO_TANGCA { get; set; }
        public Nullable<short> HESO_TANGCA { get; set; }
        public string GHI_CHU { get; set; }
        public Nullable<bool> KHOA { get; set; }
    }
}
