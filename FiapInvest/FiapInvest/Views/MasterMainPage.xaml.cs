using FiapInvest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FiapInvest.Views
{
    public partial class MasterMainPage : MasterDetailPage
    {
        public MasterMainPage()
        {
            InitializeComponent();
            menuPage.ListViewMenu.ItemSelected += OnItemSelected;

            //Verificar se o usuário está logado
            //Chamando a classe Business que acessa o DAL
            Navigation.PushModalAsync(new LoginPage());
        }



        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuModel;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.Tipo));
                menuPage.ListViewMenu.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
