using Xamarin.Forms;
using xformsmasterdetaillight.core.core.framework;
using xformsmasterdetaillight.core.view;

namespace xformsmasterdetaillight.core.core
{
    public partial class App : Application
    {
        public App()
        {
            setupAppResources();

            // The root page of your application
            MainPage = new RootPage();
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void setupAppResources()
        {
            Current.Resources = new ResourceDictionary();
            Current.Resources.Add("Locator", new ViewModelLocator());
        }
    }
}
