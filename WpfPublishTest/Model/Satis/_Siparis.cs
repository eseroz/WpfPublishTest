using Newtonsoft.Json;
using Pandap.Model.Netsis;
using Pandap.Panda_Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Pandap.Model.Satis
{
    public partial class _Siparis : MyBindableBase
    {
        private _Siparis()
        {
            SiparisKalemleri = new ObservableCollection<_SiparisKalem>();
        }

        public static _Siparis YeniSiparisOlustur()
        {
            var sip = new _Siparis();

            sip.SiparisTarih = DateTime.Now.Date;

            sip.SevkYil = DateTime.Now.Date.Year;
            sip.TeslimYil = DateTime.Now.Date.Year;

            int num = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now.Date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            sip.TeslimHafta = num;
            sip.SevkHafta = num;

            sip.BedelsizMi = false;
            sip.RowGuid = Guid.NewGuid();

            sip.SiparisKod = "Yeni Siparis";

            return sip;
        }

        public void SetDefaultValues()
        {
        }

        private string siparisKod;

        [Key]
        public string SiparisKod
        {
            get => siparisKod;
            set => SetProperty(ref siparisKod, value);
        }

        private string cariKod;

        [Required(ErrorMessage = "Bu alan girilmesi gereklidir.")]
        public string CariKod
        {
            get => cariKod;
            set => SetProperty(ref cariKod, value);
        }

        public DateTime? SiparisTarih { get; set; }
        public string SiparisSurecDurum { get; set; }
        public bool? BedelsizMi { get; set; }
        public int? SevkYil { get; set; }
        public int? SevkHafta { get; set; }
        public int? TeslimYil { get; set; }
        public int? TeslimHafta { get; set; }

        [Required(ErrorMessage = "Bu alan girilmesi gereklidir.")]
        public string OdemeTipKod { get; set; }

        public string OdemeAciklama { get; set; }

        [Required(ErrorMessage = "Bu alan girilmesi gereklidir.")]
        public string FirmaSiparisNo { get; set; }

        private string satisTipKod;

        public string SatisTipKod
        {
            get => satisTipKod;
            set => SetProperty(ref satisTipKod, value);
        }

        private string teslimTipKod;

        [Required(ErrorMessage = "Bu alan girilmesi gereklidir.")]
        public string TeslimTipKod
        {
            get => teslimTipKod;
            set => SetProperty(ref teslimTipKod, value);
        }

        private string faturaDovizTipKod;

        public string FaturaDovizTipKod
        {
            get => faturaDovizTipKod;
            set => SetProperty(ref faturaDovizTipKod, value);
        }

        private string takipDovizTipKod;

        public string TakipDovizTipKod
        {
            get => takipDovizTipKod;
            set => SetProperty(ref takipDovizTipKod, value);
        }

        private decimal? faturaDovizKuru;

        public decimal? FaturaDovizKuru
        {
            get => faturaDovizKuru;
            set => SetProperty(ref faturaDovizKuru, value);
        }

        private decimal? takipDovizKuru;

        public decimal? TakipDovizKuru
        {
            get => takipDovizKuru;
            set => SetProperty(ref takipDovizKuru, value);
        }

        public string OzelNot { get; set; }
        public string TeknikOzellikNot { get; set; }
        public string PaketlemeNot { get; set; }
        public string LmeBaglamaNot { get; set; }
        public string IrsaliyeAdresi { get; set; }

        [JsonIgnore]
        public CariKart CariKartNavigation { get; set; }

        [JsonIgnore]
        public CariEmail CariEmailNavigation { get; set; }

        [JsonIgnore]
        public OdemeTip OdemeTipKodNavigation { get; set; }

        [JsonIgnore]
        public SatisTip SatisTipKodNavigation { get; set; }

        [JsonIgnore]
        public TeslimTip TeslimTipKodNavigation { get; set; }

        [JsonIgnore]
        public DovizTip FaturaDovizTipKodNavigation { get; set; }

        [JsonIgnore]
        public DovizTip TakipDovizTipKodNavigation { get; set; }

        public ObservableCollection<_SiparisKalem> SiparisKalemleri { get; set; }

        public string CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastEditedBy { get; set; }
        public DateTime? LastEditedDate { get; set; }
        public Guid? RowGuid { get; set; }
    }
}