using Pandap.Model.Satis;
using Pandap.Panda_Model;
using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Uretim
{
    public partial class UretimEmri : MyBindableBase
    {
        [Key]
        public string UretimEmriKod { get; set; }

        public string SiparisKalemKod { get; set; }
        public string AnaKartNo { get; set; }

        public int? PlanlamaGuncelMiktar { get; set; }

        public int? PlanlananMiktar { get; set; }

        private int? paketlenenMiktar;

        public int? PaketlenenMiktar
        {
            get => paketlenenMiktar;
            set => SetProperty(ref paketlenenMiktar, value);
        }

        public int? UretimdekiMiktar => PlanlananMiktar - PaketlenenMiktar;

        public int? KalanBakiye => PlanlamaGuncelMiktar - (PaketlenenMiktar + PlanlananMiktar - PaketlenenMiktar);

        public int? Pas5 { get; set; }
        public int? Pas4 { get; set; }
        public int? Pas3 { get; set; }
        public int? Pas2 { get; set; }
        public int? Pas1 { get; set; }
        public int? Fh_Top { get; set; }
        public int? Sp { get; set; }
        public int? Dl { get; set; }
        public int? TavaGiden { get; set; }
        public int? Tavda { get; set; }
        public int? Paketlenecek { get; set; }

        public bool? KapatildiMi { get; set; }
        public bool? TekrarUretilsinMi { get; set; }

        public int? KapatmaBakiyesi { get; set; }

        public bool SonGecerliMi { get; set; }

        public _SiparisKalem SiparisKalemKodNav { get; set; }
    }
}