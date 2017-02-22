using Xamarin.Forms;
using xformsmasterdetaillight.core.core.framework;

namespace xformsmasterdetaillight.core.view
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();

            BindingContext = ((ViewModelLocator)Application.Current.Resources["Locator"]).Page3;
        }
    }
}
