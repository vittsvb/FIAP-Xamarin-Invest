using FiapInvest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapInvest.Services
{
    public class ConsultaSaldoService
    {
        public IList<ConsultaSaldoModel> ConsultaSaldo(int IdClienteConsulta)
        {
            IList<ConsultaSaldoModel> lista = new List<ConsultaSaldoModel>();

            lista.Add(new ConsultaSaldoModel
            {
                IdCliente = IdClienteConsulta,
                IdFundo = 43000,
                NomeFundo = "Renda Variavel",
                ValorInvestido = 11039.26,
                DataAtualizacao = DateTime.Now
            });

            lista.Add(new ConsultaSaldoModel
            {
                IdCliente = IdClienteConsulta,
                IdFundo = 43001,
                NomeFundo = "Fundo IPCA Based",
                ValorInvestido = 12098.00,
                DataAtualizacao = DateTime.Now
            });

            lista.Add(new ConsultaSaldoModel
            {
                IdCliente = IdClienteConsulta,
                IdFundo = 43002,
                NomeFundo = "Fundo IBOV Based",
                ValorInvestido = 72098.00,
                DataAtualizacao = DateTime.Now
            });

            lista.Add(new ConsultaSaldoModel
            {
                IdCliente = IdClienteConsulta,
                IdFundo = 43003,
                NomeFundo = "Fundo IGMP Based",
                ValorInvestido = 16098.00,
                DataAtualizacao = DateTime.Now
            });

            return lista;
        }
    }
}
