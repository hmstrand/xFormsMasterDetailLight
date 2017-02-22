using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using NavigationTest.viewmodels;
using System.Diagnostics.CodeAnalysis;
using xformsmasterdetaillight.core.core.framework.services;

namespace xformsmasterdetaillight.core.core.framework
{
    public class ViewModelLocator
    {
        //Test
        public const string Page1Key = "Page1";
        public const string Page2Key = "Page2";
        public const string Page3Key = "Page3";

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "This non-static member is needed for data binding purposes.")]
        public MenuPageViewModel MenuPage
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MenuPageViewModel>();
            }
        }

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "This non-static member is needed for data binding purposes.")]
        public Page1ViewModel Page1
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Page1ViewModel>();
            }
        }

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "This non-static member is needed for data binding purposes.")]
        public Page2ViewModel Page2
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Page2ViewModel>();
            }
        }

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "This non-static member is needed for data binding purposes.")]
        public Page3ViewModel Page3
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Page3ViewModel>();
            }
        }

        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {

            }
            else
            {
                SimpleIoc.Default.Register<INavigationService, NavigationService>();
            }

            SimpleIoc.Default.Register<MenuPageViewModel>();
            SimpleIoc.Default.Register<Page1ViewModel>();
            SimpleIoc.Default.Register<Page2ViewModel>();
            SimpleIoc.Default.Register<Page3ViewModel>();
        }
    }
}
