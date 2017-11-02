using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Satis
{
    public partial class DovizTip
    {
        [Key]
        public string DovizTipKod { get; set; }

        public string Aciklama { get; set; }
        public string Simge { get; set; }
        public int? NetsisId { get; set; }

        public ICollection<_SiparisKalem> _SiparisKalem { get; set; }
    }
}