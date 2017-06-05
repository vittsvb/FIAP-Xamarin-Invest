using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FiapInvest.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BotaoLogin.Clicked += Login;
        }

        public void Login(object o, EventArgs e)
        {
            // Efetuar chamada de serviço que valida o login
            // Se o nome e senha estiverem corretos
            // Fechar a tela de login e exibir o menu (Código Abaixo)
                Navigation.PopModalAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }


    }
}
