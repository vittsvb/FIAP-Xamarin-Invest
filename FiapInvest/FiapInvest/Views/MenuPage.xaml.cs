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
    public partial class MenuPage : ContentPage
    {
        public ListView ListItemMenu
        {
            get
            {
                return listViewMenu;
            }
        }

        public MenuPage()
        {
            InitializeComponent();
            listViewMenu.ItemsSource = carregarMenu();
        }

        private IList<MenuModel> carregarMenu()
        {
            IList<MenuModel> listaMenu = new List<MenuModel>();

            listaMenu.Add(new MenuModel
            {
                Nome = "Posição Consolidada",
                Cor = "#E44040",
                Tipo = typeof(Views.PosicaoConsolidadaPage)
            });

            listaMenu.Add(new MenuModel
            {
                Nome = "Consulta de Saldo",
                Cor = "#531968",
                Tipo = typeof(Views.ConsultaSaldoPage)
            });

            return listaMenu;
        }
    }
}
