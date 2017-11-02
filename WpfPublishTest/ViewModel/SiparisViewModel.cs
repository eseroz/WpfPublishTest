using Pandap.Model.Satis;
using Pandap.Panda_Model;

namespace WpfPublishTest.ViewModel
{
    public class SiparisViewModel : MyBindableBase
    {
        private _Siparis _siparis;

        public _Siparis Siparis { get => _siparis; set => _siparis = value; }

        public SiparisViewModel()
        {
        }
    }
}