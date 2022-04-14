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
    
    public partial class CHUYENBAY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUYENBAY()
        {
            this.CHITIETHANGVEs = new HashSet<CHITIETHANGVE>();
            this.DATCHOes = new HashSet<DATCHO>();
            this.DOANHTHUCHUYENBAYs = new HashSet<DOANHTHUCHUYENBAY>();
            this.VEs = new HashSet<VE>();
        }
    
        public int MaChuyenBay { get; set; }
        public int MaDuongBay { get; set; }
        public decimal GiaVe { get; set; }
        public System.DateTime NgayGio { get; set; }
        public bool DaKhoiHanh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHANGVE> CHITIETHANGVEs { get; set; }
        public virtual DUONGBAY DUONGBAY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DATCHO> DATCHOes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOANHTHUCHUYENBAY> DOANHTHUCHUYENBAYs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VE> VEs { get; set; }
    }
}