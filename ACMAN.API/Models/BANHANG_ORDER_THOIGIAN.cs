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
    
    public partial class BANHANG_ORDER_THOIGIAN
    {
        public long ID { get; set; }
        public byte LOAI_PM { get; set; }
        public long ID_BAN_PHONG { get; set; }
        public long ID_MAHANG { get; set; }
        public Nullable<byte> TG_BD { get; set; }
        public Nullable<byte> TG_KT { get; set; }
        public Nullable<byte> LOAI_THOIGIAN { get; set; }
        public Nullable<double> DON_GIA { get; set; }
        public string GHI_CHU { get; set; }
    }
}
