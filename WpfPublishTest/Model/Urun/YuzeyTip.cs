using Pandap.Model.Satis;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Urun
{
    public partial class YuzeyTip
    {
        [Key]
        public string YuzeyKod { get; set; }

        public string Aciklama { get; set; }
        public string Aciklama_EN { get; set; }

        public ICollection<_SiparisKalem> _SiparisKalem { get; set; }
    }
}