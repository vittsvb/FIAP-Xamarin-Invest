using FiapInvest.Models;
using System.Collections.Generic;

namespace FiapInvest.Services
{
    public class InvestidorService
    {
        /**
         * Classe Service contem os metodos que simulam uma conexão com servico externo
         * 
         * Utilizada somente como mockup
         **/
        public void Gravar(InvestidorModel model)
        {
            // Gravando as informações do Investidor
            // Fazer a Chamada da API Rest
        }

        public InvestidorModel Consultar(int idInvest)
        {
            // Mock para Consultar Investidor
            InvestidorModel Investidor = new InvestidorModel()
            {
                IdInvestidor = 1,
                NomeInvestidor = "Investidor",
                Cpf = "123.456.789-00",
                Email = "investidor@gmail.com",
                DataNascimento = new System.DateTime(1997, 8, 2),
                Perfil = "Arrojado",
                ValorPatrimonio = 350,
                Telefone = "11 4002-8922",
                perfis = ListarPerfis()    
            };

            return Investidor;
        }

        public IList<string> ListarPerfis()
        {
            IList<string> lista = new List<string>();
            lista.Add("Conservador");
            lista.Add("Moderado");
            lista.Add("Arrojado");
            lista.Add("Arriscado");
            return lista;
        }
    }
}
