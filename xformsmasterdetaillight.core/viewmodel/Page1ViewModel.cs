using GalaSoft.MvvmLight;

namespace NavigationTest.viewmodels
{
    public class  Page1ViewModel : ViewModelBase
    {
        public string MainText { get; set; }

        public Page1ViewModel()
        {
            MainText = "Page 1";
        }

    }
}
