using Pandap.Model.Satis;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Urun
{
    public partial class SertlikTip
    {
        public SertlikTip()
        {
            _SiparisKalem = new HashSet<_SiparisKalem>();
        }

        [Key]
        public string SertlikKod { get; set; }

        public string Aciklama { get; set; }
        public int? CiktiSira { get; set; }

        public ICollection<_SiparisKalem> _SiparisKalem { get; set; }
    }
}