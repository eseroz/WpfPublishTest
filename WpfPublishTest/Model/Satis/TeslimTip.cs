using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Satis
{
    public partial class TeslimTip
    {
        public TeslimTip()
        {
            _Siparis = new HashSet<_Siparis>();
        }

        [Key]
        public string TeslimTipKod { get; set; }

        public string Aciklama { get; set; }
        public string SatisTiptenFiltre { get; set; }
        public int? NetsisId { get; set; }
        public string OzelKod1 { get; set; }
        public int CiktiSira { get; set; }

        public ICollection<_Siparis> _Siparis { get; set; }
    }
}