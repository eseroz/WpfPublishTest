using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Satis
{
    public partial class SatisTip
    {
        public SatisTip()
        {
            _Siparis = new HashSet<_Siparis>();
        }

        [Key]
        public string SatisTipKod { get; set; }

        public string Aciklama { get; set; }
        public int? NetsisId { get; set; }
        public string OzelKod1 { get; set; }

        public ICollection<_Siparis> _Siparis { get; set; }
    }
}