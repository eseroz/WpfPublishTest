using Pandap.Model.Satis;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Urun
{
    public partial class KullanimAlanTip
    {
        public KullanimAlanTip()
        {
            _SiparisKalem = new HashSet<_SiparisKalem>();
        }

        [Key]
        public string KullanimAlanKod { get; set; }

        public string Aciklama { get; set; }
        public string Aciklama_EN { get; set; }

        public ICollection<_SiparisKalem> _SiparisKalem { get; set; }
    }
}