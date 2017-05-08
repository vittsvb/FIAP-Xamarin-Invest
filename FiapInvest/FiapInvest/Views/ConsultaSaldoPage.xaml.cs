using FiapInvest.Business;
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
    public partial class ConsultaSaldoPage : ContentPage
    {
        public ConsultaSaldoPage()
        {
            InitializeComponent();

            int IdUsuario = 1;
            Double saldo = 0;
            
            ConsultaSaldoBusiness consultaSaldoBusiness = new ConsultaSaldoBusiness();
            IList<ConsultaSaldoModel> listaSaldo = consultaSaldoBusiness.ConsultaSaldo(IdUsuario);

            foreach (var item in listaSaldo)
            {
                saldo += item.Saldo;
            }

            lblSaldo.Text = String.Format("{0}", saldo);           

            listViewPosicao.ItemsSource = listaSaldo;
        }
    }
}
