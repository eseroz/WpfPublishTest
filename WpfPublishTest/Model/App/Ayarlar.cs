using System;

namespace Pandap.Model.App
{
    public partial class Ayarlar
    {
        public int Id { get; set; }
        public string UygulamaAdi { get; set; }
        public string FirmaAdi { get; set; }
        public Guid? RowGuid { get; set; }
    }
}