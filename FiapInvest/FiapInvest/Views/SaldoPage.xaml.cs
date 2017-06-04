using FiapInvest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FiapInvest.Views
{
    public partial class SaldoPage : ContentPage
    {
        public SaldoPage()
        {
            InitializeComponent();
            int IdCliente = 1;
            IList<Models.SaldoFundo> saldos = new Business.SaldoBusiness().consultarSaldo(IdCliente);
            
            // Passando a lista de Saldos para o ListView
            listViewSaldo.ItemsSource = saldos;

            // Calculando o Saldo Total
            var SaldoTotal = 0.0;
            foreach( SaldoFundo saldo in saldos )
            {
                SaldoTotal += saldo.ValorSaldo;
            }

            LabelSaldo.Text = string.Format("{0:N}", SaldoTotal);
        }
    }
}
