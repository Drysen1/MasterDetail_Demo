using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterDetail_Demo.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetail_Demo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMasterPage : MasterDetailPage
    {
        public MainMasterPage()
        {
            InitializeComponent();
            mainMenuPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuItemModel;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);

            Detail = new NavigationPage(page);
            IsPresented = false;

            mainMenuPage.ListView.SelectedItem = null;
        }
    }
}