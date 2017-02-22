using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System.Collections.ObjectModel;
using xformsmasterdetaillight.core.core.framework;
using xformsmasterdetaillight.core.core.model;

namespace NavigationTest.viewmodels
{
    public class MenuPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public ObservableCollection<MenuPageItem> MenuPageItems { get; set; }


        private RelayCommand<MenuPageItem> _showDetailsCommand;
        public RelayCommand<MenuPageItem> ShowDetailsCommand
        {
            get
            {
                return _showDetailsCommand
                       ?? (_showDetailsCommand = new RelayCommand<MenuPageItem>(
                           menuPageItem =>
                           {
                               if (!ShowDetailsCommand.CanExecute(menuPageItem))
                               {
                                   return;
                               }

                               if (menuPageItem.MenuItem == MenuItem.Page1)
                                   _navigationService.NavigateTo(ViewModelLocator.Page1Key);
                               if (menuPageItem.MenuItem == MenuItem.Page2)
                                   _navigationService.NavigateTo(ViewModelLocator.Page2Key);
                               if (menuPageItem.MenuItem == MenuItem.Page3)
                                   _navigationService.NavigateTo(ViewModelLocator.Page3Key);
                           },
                           menuType => menuType != null));
            }
        }

        public MenuPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            MenuPageItems = new ObservableCollection<MenuPageItem>
            {
                new MenuPageItem { Title = "Detail Page 1", MenuItem = MenuItem.Page1},
                new MenuPageItem { Title = "Detail Page 2", MenuItem = MenuItem.Page2},
                new MenuPageItem { Title = "Detail Page 3", MenuItem = MenuItem.Page3}
            };
        }
    }
}
