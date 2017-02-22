using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using xformsmasterdetaillight.core.view;

namespace xformsmasterdetaillight.core.core.framework.services
{
    public class NavigationService : INavigationService
    {
        private Dictionary<string, Type> _pages { get; set; }

        string _currentPageKey;

        public MasterDetailPage MainPage
        {
            get
            {
                return (MasterDetailPage)Application.Current.MainPage;
            }
        }

        public NavigationService()
        {
            _pages = new Dictionary<string, Type>();
            _pages.Add("Page1", typeof(Page1));
            _pages.Add("Page2", typeof(Page2));
            _pages.Add("Page3", typeof(Page3));
        }

        #region INavigationService implementation

        public void GoBack()
        {
            MainPage.Navigation.PopAsync();
        }

        public void NavigateTo(string pageKey)
        {
            NavigateTo(pageKey, null);
        }

        public async void NavigateTo(string pageKey, object parameter)
        {
            object[] parameters = null;

            if (parameter != null)
            {
                parameters = new object[] { parameter };
            }

            Page displayPage = (Page)Activator.CreateInstance(_pages[pageKey], parameters);

            _currentPageKey = pageKey;

            MainPage.Detail = displayPage;

            //If navigation was not triggered from the menupage we probably want to navigate using
            //MainPage.Detail.Navigation.PushAsync(displayPage);

            if (MainPage.Detail != null)
            {
                if (Device.Idiom != TargetIdiom.Desktop || Device.Idiom != TargetIdiom.Desktop)
                    MainPage.IsPresented = false;

                if (Device.OS == TargetPlatform.Android)
                    await Task.Delay(300);
            }
        }

        public string CurrentPageKey
        {
            get
            {
                return _currentPageKey;
            }
        }

        #endregion
    }
}
