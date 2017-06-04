using FiapInvest.Business;
using System;
using Xamarin.Forms;

namespace FiapInvest.Views
{
    public partial class PosicaoConsolidadaPage : ContentPage
    {

        int IdUsuario = 1;

        public PosicaoConsolidadaPage()
        {
            InitializeComponent();
            listViewPosicao.ItemsSource = 
                   new PosicaoConsolidadaBusiness()
                    .ConsultarPosicaoConsolidada(IdUsuario);

            // Adicionando evento ao objeto
            BotaoSaldo.Clicked += BotaoSaldoClick;
        }

        public void BotaoSaldoClick(object o, EventArgs e)
        {
            Navigation.PushAsync(new SaldoPage());
        }

    }
}

