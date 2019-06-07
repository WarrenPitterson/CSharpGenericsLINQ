using Acme.Biz;

namespace Acme.Wpf.ViewModels
{
    public class VendorDetailViewModel
    {
        public Vendor CurrentVendor { get; set; }

        readonly VendorRepository vendorRepository = new VendorRepository();

        public VendorDetailViewModel()
        {
            LoadData();
        }

        public void LoadData()
        {
        }
    }
}
