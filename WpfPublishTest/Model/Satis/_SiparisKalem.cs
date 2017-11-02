
using Newtonsoft.Json;
using Pandap.Helper;
using Pandap.Model.Uretim;
using Pandap.Model.Urun;
using Pandap.Panda_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Satis
{
    public partial class _SiparisKalem : MyBindableBase
    {
        private _SiparisKalem()
        {
        }

        public static _SiparisKalem YeniSiparisKalemOluştur(_Siparis siparis)
        {
            var siparisKalem = new _SiparisKalem();

            siparisKalem.RowGuid = Guid.NewGuid();
            siparisKalem.lmeTutar = 0;
            siparisKalem.iscilikTutar = 0;
            siparisKalem.IscilikVadeFarkiTutar = 0;
            siparisKalem.miktar_Kg = 0;
            siparisKalem.iscilikVadeFarkiOran = 0;
            siparisKalem.kulceTutar = 0;

            siparisKalem.Kalinlik_micron = 0;
            siparisKalem.KalinlikArti_yuzde = 4;
            siparisKalem.KalinlikEksi_yuzde = -4;

            siparisKalem.RuloAgirligiMax_kg = 0;
            siparisKalem.RuloAgirligiMin_kg = 0;

            siparisKalem.RuloIcCap_mm = 0;
            siparisKalem.RuloDiscapMax_mm = 0;
            siparisKalem.RuloDiscapMin_mm = 0;

            siparisKalem.EnArti_mm = 0;
            siparisKalem.EnEksi_mm = 0;
            siparisKalem.En_mm = 0;

            siparisKalem.MaxEk = 0;

            siparisKalem.Metraj_mt = 0;
            siparisKalem.MetrajArti_mt = 0;
            siparisKalem.MetrajEksi_mt = 0;

            siparisKalem.MasuraTipKod = "AL";
            siparisKalem.Miktar_kg = 1;
            siparisKalem.BirimFiyat = 0;

            siparisKalem.LmeDovizTipKod = siparis.TakipDovizTipKod;
            siparisKalem.KulceDovizTipKod = siparis.TakipDovizTipKod;
            siparisKalem.IscilikDovizTipKod = siparis.TakipDovizTipKod;

            siparisKalem.KdvOran = siparis.SatisTipKod == SATISTIPI.YI
                                            && (siparis.TeslimTipKod == "IHR") ? 0 : 18;

            siparisKalem.KdvOran = siparis.SatisTipKod == SATISTIPI.YD ? 0 : siparisKalem.KdvOran;

          

            return siparisKalem;
        }

        private string siparisKalemKod;

        [Key]
        public string SiparisKalemKod
        {
            get => siparisKalemKod;
            set => SetProperty(ref siparisKalemKod, value);
        }

        public string SiparisKod { get; set; }

        public string MusteriUrunKodu { get; set; }

        [Required(ErrorMessage = "Bu alan girilmesi gereklidir.")]
        public string LmeTipKod { get; set; }

        public string LmeDovizTipKod { get; set; }


        public DateTime? LmeTarih { get; set; }
        private decimal? lmeTutar;

        public decimal? LmeTutar
        {
            get => lmeTutar;
            set { SetProperty(ref lmeTutar, value); GenelToplamlariGuncelle(); }
        }

        public string KulcePrimTipKod { get; set; }
        public string KulceDovizTipKod { get; set; }
        public DateTime? KulceTarih { get; set; }
        private decimal? kulceTutar;

        public decimal? KulceTutar
        {
            get => kulceTutar;
            set { SetProperty(ref kulceTutar, value); GenelToplamlariGuncelle(); }
        }

        public string IscilikDovizTipKod { get; set; }

        private decimal? iscilikVadeFarkiOran;

        public decimal? IscilikVadeFarkiOran
        {
            get => iscilikVadeFarkiOran;
            set { SetProperty(ref iscilikVadeFarkiOran, value); GenelToplamlariGuncelle(); }
        }

        private decimal? iscilikTutar;

      
        public decimal? IscilikTutar
        {
            get => iscilikTutar;
            set { SetProperty(ref iscilikTutar, value); GenelToplamlariGuncelle(); }
        }

        public string BirimTipKod { get; set; }

        private int? miktar_Kg;

        public int? Miktar_kg
        {
            get => miktar_Kg;
            set { SetProperty(ref miktar_Kg, value); GenelToplamlariGuncelle(); }
        }

        private decimal? birimFiyat;

        public decimal? BirimFiyat
        {
            get => birimFiyat;
            set => SetProperty(ref birimFiyat, value);
        }

        private decimal? kdvOran;

        public decimal? KdvOran
        {
            get => kdvOran;
            set => SetProperty(ref kdvOran, value);
        }

        private decimal? toplamTutar;

        public decimal? ToplamTutar
        {
            get => toplamTutar;
            set => SetProperty(ref toplamTutar, value);
        }

        private decimal? iscilikVadeFarkiTutar;

        public decimal? IscilikVadeFarkiTutar
        {
            get => iscilikVadeFarkiTutar;
            set => SetProperty(ref iscilikVadeFarkiTutar, value);
        }

        private decimal? kdvTutar;

        public decimal? KdvTutar
        {
            get => kdvTutar;
            set => SetProperty(ref kdvTutar, value);
        }

        private decimal? genelToplamTutar;

        public decimal? GenelToplamTutar
        {
            get => genelToplamTutar;
            set => SetProperty(ref genelToplamTutar, value);
        }

        private string urunKod;

        [Required(ErrorMessage = "Bu alan girilmesi gereklidir.")]
        public string UrunKod
        {
            get => urunKod;
            set => SetProperty(ref urunKod, value);
        }

        private string alasimTipKod;

        [Required(ErrorMessage = "Bu alan girilmesi gereklidir.")]
        public string AlasimTipKod
        {
            get => alasimTipKod;
            set => SetProperty(ref alasimTipKod, value);
        }

        private string sertlikTipKod;

        [Required(ErrorMessage = "Bu alan girilmesi gereklidir.")]
        public string SertlikTipKod
        {
            get => sertlikTipKod;
            set => SetProperty(ref sertlikTipKod, value);
        }

        [Required(ErrorMessage = "Bu alan girilmesi gereklidir.")]
        public string MasuraTipKod { get; set; }

        [Required(ErrorMessage = "Bu alan girilmesi gereklidir.")]
        public string KullanimAlanTipKod { get; set; }

        [Required(ErrorMessage = "Bu alan girilmesi gereklidir.")]
        public string YuzeyTipKod { get; set; }

        [Required(ErrorMessage = "Bu alan girilmesi gereklidir.")]
        public string AmbalajTipKod { get; set; }

        [Required(ErrorMessage = "Bu alan girilmesi gereklidir.")]
        public string GumrukTipKod { get; set; }

        public int? MaxEk { get; set; }

     
        public decimal? Kalinlik_micron { get; set; }

        public int? KalinlikArti_yuzde { get; set; }
        public int? KalinlikEksi_yuzde { get; set; }

     
        public decimal? En_mm { get; set; }

        public decimal? EnArti_mm { get; set; }
        public decimal? EnEksi_mm { get; set; }

      
        public int? Metraj_mt { get; set; }

      
        public int? MetrajArti_mt { get; set; }

       
        public int? MetrajEksi_mt { get; set; }

        public int? RuloIcCap_mm { get; set; }

      
        public int? RuloDiscapMax_mm { get; set; }

      
        public int? RuloDiscapMin_mm { get; set; }

        public int? RuloAgirligiMax_kg { get; set; }
        public int? RuloAgirligiMin_kg { get; set; }

     
        public _Siparis SiparisNav { get; set; }

        
        public BirimTip BirimTipKodNavigation { get; set; }

       
        public LmeTip LmeTipKodNavigation { get; set; }

     
        public DovizTip LmeDovizTipKodNavigation { get; set; }
        

        
        public _Urun UrunKodNavigation { get; set; }

        [JsonIgnore]
        public AlasimTip AlasimTipKodNavigation { get; set; }

        [JsonIgnore]
        public AmbalajTip AmbalajTipKodNavigation { get; set; }

        [JsonIgnore]
        public GumrukTip GumrukTipKodNavigation { get; set; }

        [JsonIgnore]
        public KullanimAlanTip KullanimAlanTipKodNavigation { get; set; }

        [JsonIgnore]
        public MasuraTip MasuraTipKodNavigation { get; set; }

        [JsonIgnore]
        public SertlikTip SertlikTipKodNavigation { get; set; }

        [JsonIgnore]
        public YuzeyTip YuzeyTipKodNavigation { get; set; }

        [JsonIgnore]
        public List<UretimEmri> UretimEmirleri { get; set; } = new List<UretimEmri>();

        public string CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastEditedBy { get; set; }
        public DateTime? LastEditedDate { get; set; }
        public Guid? RowGuid { get; set; }

        public void GenelToplamlariGuncelle()
        {
            if (lmeTutar == null || kulceTutar == null || iscilikTutar == null) return;

            BirimFiyat = (decimal)(lmeTutar + kulceTutar + iscilikTutar) / 1000;
            ToplamTutar = birimFiyat * Miktar_kg;
            IscilikVadeFarkiTutar = toplamTutar * (iscilikVadeFarkiOran / (decimal)100.0);
            KdvTutar = (iscilikVadeFarkiTutar + toplamTutar) * kdvOran / (decimal)100.0;
            GenelToplamTutar = (toplamTutar + iscilikVadeFarkiTutar + kdvTutar);
        }
    }
}