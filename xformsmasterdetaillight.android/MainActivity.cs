using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using xformsmasterdetaillight.core.core;

namespace xformsmasterdetaillight.core.android
{
    [Activity(
        Label = "Test", 
        MainLauncher = true, 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

