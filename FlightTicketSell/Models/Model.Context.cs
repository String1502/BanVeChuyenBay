﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FlightTicketSellEntities : DbContext
    {
        public FlightTicketSellEntities()
            : base("name=FlightTicketSellEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHITIETDATCHO> CHITIETDATCHOes { get; set; }
        public virtual DbSet<CHITIETHANGVE> CHITIETHANGVEs { get; set; }
        public virtual DbSet<CHUYENBAY> CHUYENBAYs { get; set; }
        public virtual DbSet<DATCHO> DATCHOes { get; set; }
        public virtual DbSet<DOANHTHUCHUYENBAY> DOANHTHUCHUYENBAYs { get; set; }
        public virtual DbSet<DOANHTHUNAM> DOANHTHUNAMs { get; set; }
        public virtual DbSet<DOANHTHUTHANG> DOANHTHUTHANGs { get; set; }
        public virtual DbSet<DUONGBAY> DUONGBAYs { get; set; }
        public virtual DbSet<HANGVE> HANGVEs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<SANBAY> SANBAYs { get; set; }
        public virtual DbSet<SANBAYTG> SANBAYTGs { get; set; }
        public virtual DbSet<THAMSO> THAMSOes { get; set; }
        public virtual DbSet<VE> VEs { get; set; }
    }
}
