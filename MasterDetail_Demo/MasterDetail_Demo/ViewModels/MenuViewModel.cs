using MasterDetail_Demo.Models;
using MasterDetail_Demo.Views;
using System.Collections.ObjectModel;

namespace MasterDetail_Demo.ViewModels
{
    public class MenuViewModel
    {
        public ObservableCollection<MenuItemModel> MenuItems { get; }

        public MenuViewModel()
        {
            MenuItems = new ObservableCollection<MenuItemModel>();
            LoadMenuItems();
        }

        private void LoadMenuItems()
        {
            MenuItems.Add(new MenuItemModel { Id = 0, Title = "TestPage1", IconSource = "icon.png", TargetType = typeof(Page1) });
            MenuItems.Add(new MenuItemModel { Id = 1, Title = "TestPage2", IconSource = "icon.png", TargetType = typeof(Page2) });
        }
    }
}
