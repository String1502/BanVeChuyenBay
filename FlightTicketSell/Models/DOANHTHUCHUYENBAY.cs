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
    
    public partial class DOANHTHUCHUYENBAY
    {
        public int MaDoanhThuChuyenBay { get; set; }
        public int MaDoanhThuThang { get; set; }
        public int MaChuyenBay { get; set; }
        public int SoVe { get; set; }
        public decimal DoanhThu { get; set; }
        public decimal TiLe { get; set; }
    
        public virtual CHUYENBAY CHUYENBAY { get; set; }
        public virtual DOANHTHUTHANG DOANHTHUTHANG { get; set; }
    }
}