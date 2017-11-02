using System;

namespace Pandap.Model.App
{
    public partial class Mesaj
    {
        public int Id { get; set; }
        public bool? GidenMi { get; set; }
        public Guid? RefEntityGuid { get; set; }
        public string DokumanAdi { get; set; }
        public DateTime? MesajTarihi { get; set; }
        public string Resim { get; set; }
        public string Gonderen { get; set; }
        public string Alan { get; set; }
        public string DosyaAdi { get; set; }
        public string MesajIcerik { get; set; }
    }
}