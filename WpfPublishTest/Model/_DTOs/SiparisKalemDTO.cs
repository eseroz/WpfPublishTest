using Pandap.Model.Uretim;
using Pandap.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pandap.Persistence.DTOs
{
    public class SiparisKalemDTO
    {
        public string SiparisKalemKod { get; set; }

        public Guid KalemRowGuid { get; set; }

        [ForeignKey(nameof(SiparisNavigation))]
        public string SiparisKod { get; set; }

        public SiparisDTO SiparisNavigation { get; set; }

        public SiparisKalemDTO()
        {
            UretimEmirleri = new List<UretimEmri>();
        }

        public string GrupDurum { get; set; }

        public string UretimEmriKod { get; set; }

        public decimal PlanlamaGuncelMiktar { get; set; }

        public string UrunKod { get; set; }

        public string AlasimTipAd { get; set; }
        public string SertlikTipAd { get; set; }
        public string MasuraTipAd { get; set; }
        public string YuzeyTipAd { get; set; }
        public string AmbalajTipAd { get; set; }
        public string KullanimAlanTipAd { get; set; }

        public int MaxEk { get; set; }
        public decimal Kalinlik { get; set; }
        public int KalinlikArti { get; set; } //%
        public int KalinlikEksi { get; set; } //%

        public int Metraj { get; set; }
        public int MetrajArti { get; set; } //%
        public int MetrajEksi { get; set; } //%

        public decimal En { get; set; }
        public decimal EnArti { get; set; }
        public decimal EnEksi { get; set; }

        public int RuloAgirlikMax { get; set; }
        public int RuloAgirlikMin { get; set; }

        public int RuloDiscapMax { get; set; }
        public int RuloDiscapMin { get; set; }
        public int RuloIcCap { get; set; }

        public int Miktar { get; internal set; }
        public int UretimdekiMiktar { get; internal set; }
        public decimal UretimdekiMiktarYuzde { get; internal set; }

        public int PlanlananMiktar { get; internal set; }

        public int PlanlamaBakiye { get; set; }

        public int PaketlenenMiktar { get; set; }
        public int FireMiktar { get; set; }

        public string SevkHaftasi { get; internal set; }
        public string TeslimHaftasi { get; internal set; }

        public string UlkeKodIso { get; internal set; }
        public DateTime? Tarih { get; internal set; }
        public string CariIsim { get; internal set; }

        public string IscilikTutar { get; internal set; }
        public string KulcePrimi { get; internal set; }

        public List<UretimEmri> UretimEmirleri { get; internal set; }

        public string AnaKartNo { get; internal set; }
        public int? PlanlamaDurum { get; internal set; }

        public bool KapatildiMi { get; set; }
        public bool PlanlamaSevkOnayliMi { get; internal set; }
    }
}