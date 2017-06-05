using System;
using System.Collections.Generic;

namespace FiapInvest.Models
{
    public class InvestidorModel
    {
        /**
         * Classe Model, contem as informacoes que serao exibidas ou inseridas a partir da tela DadosInvestidorPage.xaml
         **/
        public int IdInvestidor { get; set; }
        public String NomeInvestidor { get; set; }
        public String Cpf { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public String Perfil { get; set; }
        public double ValorPatrimonio { get; set; }
        public DateTime DataNascimento { get; set; }

        public IList<string> perfis { get; set; }
    }
}
