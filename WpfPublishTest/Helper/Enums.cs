namespace Pandap.Helper
{
    public struct SATISTIPI
    {
        public const string YI = "YI";
        public const string YD = "YD";
    }

    public class KullaniciRolleri
    {
        public static string ADMIN { get => "ADMIN"; }
        public static string OPERASYON { get => "OPERASYON"; }
        public static string SATIS { get => "SATIS"; }
        public static string YONETICI { get => "YONETICI"; }
        public static string PAKETLEME { get => "PAKETLEME"; }
        public static string PLANLAMA { get => "PLANLAMA"; }
    }

    public class SiparisSurecDurum
    {
        public static string SATISTA { get => "SATIŞTA"; }
        public static string PLANLAMADA { get => "PLANLAMADA"; }
        public static string YONETICIONAYINDA { get => "YÖNETİCİ ONAYINDA"; }
        public static string MUSTERIONAYINDA { get => "MÜŞTERİ ONAYINDA"; }
        public static string MUSTERIONAYLI { get => "MÜŞTERİ ONAYLI"; }
        public static string OPERASYONDA { get => "OPERASYONDA"; }
        public static string URETIMDE { get => "ÜRETİMDE"; }
    }

    public enum FormulEnum
    {
        Metraj_Rulodan,
        RuloAgirligiMax_Metrajdan,
        RuloAgirligiMax_Rulodan,
        Discap_Rulodan
    }

    public enum KayitModu
    {
        Yeni,
        Edit,
        KopyadanYeni,
        Varsayılan,
        LogKaydi
    }

    public enum Language
    {
        TR,
        EN
    }

    public enum DovizCinsleri
    {
        USD = 0,
        EURO = 1,
        GBP = 2
    }

    public enum PlanlamaDurum
    {
        AcikSiparis = 0,
        Planlamada = 1,
        MuşteriOnayiBekleniyor = 2,
        MusteriOnayladi = 3,
        Uretimde = 4
    }

    public enum NavMenu
    {
        AçıkSiparişMenu,
        PanlamaBekleyenlerMenu,
        MusteriOnayiBekleyenlerMenu,
        MusteriOnayliSiparislerMenu,
        UretimdekiSiparislerMenu
    }
}