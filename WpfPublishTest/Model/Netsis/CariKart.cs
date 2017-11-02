using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Netsis
{
    public partial class CariKart
    {
        [Key]
        public string CariKod { get; set; }
        public string CariIsim { get; set; }

        public string PlasiyerKod { get; set; }
        public string CariTel { get; set; }
        public string CariIl { get; set; }
        public string UlkeKod { get; set; }
      
        public string CariTip { get; set; }
        public string CariAdres { get; set; }
        public string CariIlce { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNumarasi { get; set; }
        public byte DovizTipNetsisKod { get; set; }
        public string DovizAd { get; set; }

        public string Fax { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
    }
}