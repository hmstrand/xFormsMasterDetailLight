using Xamarin.Forms;
using xformsmasterdetaillight.core.core.framework;

namespace xformsmasterdetaillight.core.view
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();

            BindingContext = ((ViewModelLocator)Application.Current.Resources["Locator"]).Page2;
        }
    }
}
