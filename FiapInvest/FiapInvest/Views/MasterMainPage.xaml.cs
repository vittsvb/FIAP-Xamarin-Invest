using FiapInvest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FiapInvest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterMainPage : MasterDetailPage
    {
        public MasterMainPage()
        {
            InitializeComponent();
            menuPage.ListItemMenu.ItemSelected += OnItemSelected;

            Navigation.PushModalAsync(new LoginPage());
        }

        public void OnItemSelected(Object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuModel;

            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.Tipo));
                menuPage.ListItemMenu.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
