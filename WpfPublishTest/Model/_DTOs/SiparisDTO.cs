using Pandap.Panda_Model;
using Pandap.Persistence.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pandap.ViewModel
{
    public class SiparisDTO : MyBindableBase
    {
        [Key]
        public string SiparisKod { get; set; }

        private DateTime? tarih;

        public DateTime? Tarih
        {
            get => tarih;
            set => SetProperty(ref tarih, value);
        }

        public Guid RowGuid { get; set; }

        public string TeslimHaftasi { get; set; }
        public string SevkHaftasi { get; set; }

        public string LmeBaglamaDurumu { get; set; }

        public SiparisDTO()
        {
            SiparisKalemleri = new List<SiparisKalemDTO>();
        }

        private string cariKod;

        public string CariKod
        {
            get => cariKod;
            set => SetProperty(ref cariKod, value);
        }

        private string cariIsim;

        public string CariIsim
        {
            get => cariIsim;
            set => SetProperty(ref cariIsim, value);
        }

        private int miktarKg;

        public int MiktarKg
        {
            get => miktarKg;
            set => SetProperty(ref miktarKg, value);
        }

        public decimal? GenelToplamTutar { get; set; }

        private string plasiyer;

        public string Plasiyer
        {
            get => plasiyer;
            set => SetProperty(ref plasiyer, value);
        }

        public string SiparisSurecDurum { get; set; }

        public string TeknikOzellikNot { get; set; }
        public string PaketlemeNot { get; set; }

        public List<SiparisKalemDTO> SiparisKalemleri { get; set; }

        public string UlkeKodIso { get; internal set; }
        public string GenelToplamTutarKurlu { get; internal set; }
        public decimal GenelIscilikTutar { get; internal set; }
        public decimal GenelIscilikVadeFarkiTutar { get; internal set; }
        public decimal GenelIscilikTutarOrt { get; internal set; }
        public decimal UretimdekiMiktar { get; internal set; }
        public decimal SiparisKalanMiktar { get; internal set; }
    }
}