using Pandap.Panda_Model;
using System.ComponentModel.DataAnnotations;

public class SiparisDurumGrupSayı : MyBindableBase
{
    private int _siparisDurumSayi;

    [Key]
    public string GrupAd { get; set; }

    public int SiparisDurumSayı
    {
        get { return _siparisDurumSayi; }
        set { SetProperty(ref _siparisDurumSayi, value); }
    }
}