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
    
    public partial class CHITIETHANGVE
    {
        public int MaCTHV { get; set; }
        public int MaHangVe { get; set; }
        public int MaChuyenBay { get; set; }
        public int SoGhe { get; set; }
    
        public virtual HANGVE HANGVE { get; set; }
        public virtual CHUYENBAY CHUYENBAY { get; set; }
    }
}
