using System;
using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Netsis
{
    public partial class CariRiskKontrol
    {
        [Key]
        public string CariKod { get; set; }

        public DateTime Baz_Tarihi { get; set; }
        public string Firma_Unvani { get; set; }
        public decimal? Borc_Toplami { get; set; }
        public decimal? Alacak_Toplami { get; set; }
        public decimal? Teminat { get; set; }
        public decimal? RiskLimiti { get; set; }
        public decimal? Bakiye { get; set; }
        public decimal? Cek_Asil_Riski { get; set; }
        public decimal? Cek_Ciro_Riski { get; set; }
        public decimal? Toplam { get; set; }
        public decimal? D_Bakiye { get; set; }
        public string DovizTuru { get; set; }
        public double? RiskLimitiDoviz { get; set; }
    }
}