using System;
using System.Collections.Generic;
using FiapInvest.Models;
using Xamarin.Forms;

namespace FiapInvest.Views
{
    public partial class MenuPage : ContentPage
    {

        public ListView ListViewMenu { get { return listViewMenu; } }

        public MenuPage()
        {
            InitializeComponent();
            listViewMenu.ItemsSource = carregarMenu();
        }

        private IList<MenuModel> carregarMenu()
        {
            IList<MenuModel> lista = new List<MenuModel>();
            lista.Add(new MenuModel
            {
                Nome = "Posição Consolidada",
                Cor = "#E44040",
                Tipo = typeof(Views.PosicaoConsolidadaPage)
            });

            
            lista.Add(new MenuModel
            {
                Nome = "Saldo",
                Cor = "#444",
                Tipo = typeof(Views.SaldoPage)
            });


            lista.Add(new MenuModel
            {
                Nome = "Dados Investidor",
                Cor = "#E44040",
                Tipo = typeof(Views.DadosInvestidorPage)
            });

            return lista;
        }

    }


}
