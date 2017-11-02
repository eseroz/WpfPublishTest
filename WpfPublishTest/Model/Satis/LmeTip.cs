using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Satis
{
    public partial class LmeTip
    {
        public LmeTip()
        {
            _SiparisKalem = new HashSet<_SiparisKalem>();
        }

        [Key]
        public string LmeTipKod { get; set; }

        public string Aciklama { get; set; }
        public int? CiktiSira { get; set; }

        public ICollection<_SiparisKalem> _SiparisKalem { get; set; }
    }
}