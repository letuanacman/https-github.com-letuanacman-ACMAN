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
    
    public partial class DON_VI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DON_VI()
        {
            this.TK_SODU_DKY = new HashSet<TK_SODU_DKY>();
        }
    
        public long ID { get; set; }
        public Nullable<byte> CAP { get; set; }
        public string TEN_DN { get; set; }
        public string MST { get; set; }
        public string DIA_CHI { get; set; }
        public string TK_NGANHANG { get; set; }
        public string NGAN_HANG { get; set; }
        public string GIAM_DOC { get; set; }
        public string TINH_TP { get; set; }
        public string QUAN_HUYEN { get; set; }
        public string DIEN_THOAI { get; set; }
        public string EMAIL { get; set; }
        public string NGAYBD { get; set; }
        public string CQ_THUE { get; set; }
        public string NGHANH_NGHE_KD { get; set; }
        public string NGAY_THANHLAP { get; set; }
        public Nullable<short> SOLAN_THAYDOI { get; set; }
        public string NGAY_THAYDOI { get; set; }
        public string WEBSITE { get; set; }
        public string CQ_CAP_TREN { get; set; }
        public string MST_CAP_TREN { get; set; }
        public string DAILY_THUE { get; set; }
        public string DIA_CHI_THUE { get; set; }
        public string QUAN_HUYEN_THUE { get; set; }
        public string TINH_TP_THUE { get; set; }
        public string DIEN_THOAI_THUE { get; set; }
        public string FAX_THUE { get; set; }
        public string EMAIL_THUE { get; set; }
        public string HOP_DONG_THUE { get; set; }
        public string NGAY_HOPDONG_THUE { get; set; }
        public string CHUNGCHI_THUE { get; set; }
        public string NHANVIEN_THUE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TK_SODU_DKY> TK_SODU_DKY { get; set; }
    }
}
