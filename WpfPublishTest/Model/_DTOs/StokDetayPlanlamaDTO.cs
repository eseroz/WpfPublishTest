using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
public class StokDetayPlanlamaDTO
{
    [Key]
    public int ID { get; set; }
    public string SiparisAltKod { get; set; }
    public Guid EntityGuid { get; set; }
    public string STOK_KODU { get; set; }

    public int STOKHAREKETID { get; set; }
    public string BELGENO { get; set; }
    public string CARI_KOD { get; set; }
    public string CARI_ISIM { get; set; }
    public double MIKTAR { get; set; }
    public string AlasimADI { get; set; }
    public int PLANLAMADURUM { get; set; }
    public string PLASIYER { get; set; }


    public decimal? EN { get; set; }
    public decimal? KALINLIK { get; set; }
    public int? TERMINHAFTA { get; set; }

    public bool? REDDEDILDIMI { get; set; }
    public bool? RED_NEDENI { get; set; }

    public int? PLANLAMAHAFTA { get; set; }
    
}




