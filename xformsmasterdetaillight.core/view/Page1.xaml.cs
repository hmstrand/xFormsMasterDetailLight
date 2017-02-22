using Xamarin.Forms;
using xformsmasterdetaillight.core.core.framework;

namespace xformsmasterdetaillight.core.view
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            BindingContext = ((ViewModelLocator)Application.Current.Resources["Locator"]).Page1;
        }
    }
}
