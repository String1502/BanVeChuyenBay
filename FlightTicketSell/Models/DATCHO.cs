//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightTicketSell.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DATCHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DATCHO()
        {
            this.CHITIETDATCHOes = new HashSet<CHITIETDATCHO>();
        }
    
        public int MaDatCho { get; set; }
        public int MaHangVe { get; set; }
        public int MaChuyenBay { get; set; }
        public int MaNguoiDat { get; set; }
        public System.DateTime NgayGioDat { get; set; }
        public int SoVeDat { get; set; }
        public decimal GiaTien { get; set; }
        public string TrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDATCHO> CHITIETDATCHOes { get; set; }
        public virtual HANGVE HANGVE { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual CHUYENBAY CHUYENBAY { get; set; }
    }
}
