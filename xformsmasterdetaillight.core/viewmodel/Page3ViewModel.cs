using GalaSoft.MvvmLight;

namespace NavigationTest.viewmodels
{
    public class Page3ViewModel : ViewModelBase
    {
        public string MainText { get; set; }

        public Page3ViewModel()
        {
            MainText = "Page 3";
        }
    }
}
