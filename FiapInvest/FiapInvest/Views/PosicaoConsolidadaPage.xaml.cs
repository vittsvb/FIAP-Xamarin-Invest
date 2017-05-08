using FiapInvest.Business;
using Xamarin.Forms;

namespace FiapInvest.Views
{
    public partial class PosicaoConsolidadaPage : ContentPage
    {
        public PosicaoConsolidadaPage()
        {
            InitializeComponent();

            int IdUsuario = 1;

            PosicaoConsolidadaBusiness business = new PosicaoConsolidadaBusiness();
            listViewPosicao.ItemsSource = business.ConsultarPosicaoConsolidada(IdUsuario); 
        }
    }
}

