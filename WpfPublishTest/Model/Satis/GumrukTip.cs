using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Satis
{
    public partial class GumrukTip
    {
        public GumrukTip()
        {
            _SiparisKalem = new HashSet<_SiparisKalem>();
        }

        [Key]
        public string GumrukTipKod { get; set; }

        public string Aciklama { get; set; }
        public int CiktiSira { get; set; }
        public ICollection<_SiparisKalem> _SiparisKalem { get; set; }
    }
}