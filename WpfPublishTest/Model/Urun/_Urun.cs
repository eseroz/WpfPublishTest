using Pandap.Model.Satis;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Urun
{
    public partial class _Urun
    {
        [Key]
        public string UrunKod { get; set; }

        public string UrunGrubu { get; set; }
        public string AlasimKod { get; set; }
        public string YuzeyKod { get; set; }
        public string KalinlikIfade { get; set; }
        public int? KalinlikKosul { get; set; }
        public int? CiktiSira { get; set; }

        public _Urun()
        {
            _SiparisKalem = new HashSet<_SiparisKalem>();
        }

        public ICollection<_SiparisKalem> _SiparisKalem { get; set; }
    }
}