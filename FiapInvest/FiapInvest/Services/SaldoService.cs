using FiapInvest.Models;
using System.Collections.Generic;

namespace FiapInvest.Services
{
    public class SaldoService
    {

        public IList<SaldoFundo> consultarSaldo(int IdClienteConsulta)
        {
            IList<SaldoFundo> lista = new List<SaldoFundo>();

            lista.Add(new SaldoFundo
            {
                IdCliente = IdClienteConsulta,
                IdFundo = 43001,
                NomeFundo = "Itau RF IPCA",
                Cor = "#d9edf7",
                ValorSaldo = 2098.98
            });

            lista.Add(new SaldoFundo
            {
                IdCliente = IdClienteConsulta,
                IdFundo = 43001,
                NomeFundo = "Kinea Renda",
                Cor = "#e86a08",
                ValorSaldo = 12098.12
            });

            lista.Add(new SaldoFundo
            {
                IdCliente = IdClienteConsulta,
                IdFundo = 43001,
                NomeFundo = "XP RF",
                Cor = "#bce8f1",
                ValorSaldo = 12098.00
            });

            lista.Add(new SaldoFundo
            {
                IdCliente = IdClienteConsulta,
                IdFundo = 43001,
                NomeFundo = "JPMorgan RF IPCA",
                Cor = "#d9edf7",
                ValorSaldo = 112098.40
            });

            return lista;
        }


    }
}
