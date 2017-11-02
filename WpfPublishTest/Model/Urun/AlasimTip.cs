using Pandap.Model.Satis;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Urun
{
    public partial class AlasimTip
    {
        public AlasimTip()
        {
            _SiparisKalem = new HashSet<_SiparisKalem>();
        }

        [Key]
        public string AlasimKod { get; set; }

        public string Aciklama { get; set; }

        public ICollection<_SiparisKalem> _SiparisKalem { get; set; }
    }
}