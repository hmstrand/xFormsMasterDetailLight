using NavigationTest.viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using xformsmasterdetaillight.core.core.framework;
using xformsmasterdetaillight.core.core.model;

namespace xformsmasterdetaillight.core.view
{
    public partial class MenuPage : ContentPage
    {
        public MenuPageViewModel Vm
        {
            get
            {
                return (MenuPageViewModel)BindingContext;
            }
        }

        public MenuPage()
        {
            InitializeComponent();

            BindingContext = ((ViewModelLocator)Application.Current.Resources["Locator"]).MenuPage;

            ListViewMenu.ItemSelected += (s, e) =>
            {
                if (ListViewMenu.SelectedItem == null)
                    return;

                Vm.ShowDetailsCommand.Execute((MenuPageItem)e.SelectedItem);
                InvalidateMeasure();
            };
        }
    }
}
