using GalaSoft.MvvmLight;

namespace NavigationTest.viewmodels
{
    public class Page2ViewModel : ViewModelBase
    {
        public string MainText { get; set; }

        public Page2ViewModel()
        {
            MainText = "Page 2";
        }
    }
}
