using System.ComponentModel.DataAnnotations;

namespace Pandap.Model.Netsis
{
    public partial class CariEmail
    {
        [Key]
        public string CariKod { get; set; }

        public string YetkiliKisi { get; set; }
        public string Unvan { get; set; }
        public string Tel { get; set; }
        public string DahiliTel { get; set; }
        public string CepTel { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
    }
}