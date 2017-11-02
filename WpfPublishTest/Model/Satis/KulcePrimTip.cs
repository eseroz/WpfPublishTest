using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Satis
{
    public partial class KulcePrimTip
    {
        [Key]
        public string KulcePrimTipKod { get; set; }

        public string Aciklama { get; set; }
    }
}