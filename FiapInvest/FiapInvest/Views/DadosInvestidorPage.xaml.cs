using FiapInvest.Business;
using FiapInvest.Models;
using System;
using Xamarin.Forms;

namespace FiapInvest.Views
{
    public partial class DadosInvestidorPage : ContentPage
    {
        //Cria uma referencia para o Model do Investidor
        public InvestidorModel investidorModel { get; set; }
        private int IdUsuario = 1;

        public DadosInvestidorPage()
        {
            InitializeComponent(); //Essa linha deve ser sempre a primeira do metodo contrutor da tela

            //Instancia o Investidor busines para receber um usuario pela sua id, a variavel esta iniciada em 1
            investidorModel = new InvestidorBusiness().Consultar(IdUsuario);
            
            /** 
             * BindContext é um atributo da tela que faz a ligacao do xaml e o model por meio de data-bind
             * e estamos passando um InvestidorModel para que os campos possam preenchidos ou inserir dados no model
             **/
            BindingContext = investidorModel;

            //Cria o evento click no botao chamando o metodo GravarInvestidor
            ButtonGravar.Clicked += GravarInvestidor;            
        }

        /**
         * Metodo utilizado como evento para gravar um investidor 
         **/
        public void GravarInvestidor(object o, EventArgs e)
        {
            //Chamada do metodo gravar no InvestidorBusiness
            InvestidorBusiness business = new InvestidorBusiness();
            business.Gravar(investidorModel);

            //Caixa de alerta mostrando que o investidor foi gravado
            DisplayAlert("Sucesso", "Investidor " + investidorModel.NomeInvestidor +" Cadastrado", "Cancel");
        }
    }
}
