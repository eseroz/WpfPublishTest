using System;
using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.App
{
    public partial class Kullanici
    {
        [Key]
        public string KullaniciId { get; set; }

        public string Email { get; set; }
        public string AdSoyad { get; set; }
        public string KullaniciRol { get; set; }
        public string Parola { get; set; }
        public string BagliKullanicilar { get; set; }
        public string BagliNetsisPlasiyerKodlari { get; set; }
        public string NetsisKullaniciAdi { get; set; }
        public string NetsisParola { get; set; }
        public string Resim { get; set; }
        public DateTime? LastLoginDate { get; set; }
    }
}