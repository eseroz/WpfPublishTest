using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Satis
{
    public partial class OdemeTip
    {
        public OdemeTip()
        {
            _Siparis = new HashSet<_Siparis>();
        }

        [Key]
        public string OdemeTipKod { get; set; }

        public string Aciklama { get; set; }
        public string Aciklama_En { get; set; }

        public ICollection<_Siparis> _Siparis { get; set; }
    }
}