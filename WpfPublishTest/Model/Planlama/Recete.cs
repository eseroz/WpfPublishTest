using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Planlama
{
    public partial class Recete
    {
        [Key]
        public int Id { get; set; }

        public string KullanimAlani { get; set; }
        public string RotaUrunKodlari { get; set; }
        public decimal? HedefKalinlik { get; set; }
        public string M1 { get; set; }
        public decimal? Gk1 { get; set; }
        public decimal? Ck1 { get; set; }
        public string M2 { get; set; }
        public decimal? Gk2 { get; set; }
        public decimal? Ck2 { get; set; }
        public string M3 { get; set; }
        public decimal? Gk3 { get; set; }
        public decimal? Ck3 { get; set; }
        public string M4 { get; set; }
        public decimal? Gk4 { get; set; }
        public decimal? Ck4 { get; set; }
        public string M5 { get; set; }
        public decimal? Gk5 { get; set; }
        public decimal? Ck5 { get; set; }
        public string M6 { get; set; }
        public string M7 { get; set; }
    }
}