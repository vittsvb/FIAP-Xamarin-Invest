using FiapInvest.Models;
using System;
using System.Collections.Generic;

namespace FiapInvest.Services
{
    public class PosicaoConsolidadaService
    {
        public IList<PosicaoConsolidada> ConsultarPosicaoConsolidada(int IdClienteConsulta)
        {
            IList<PosicaoConsolidada> lista = new List<PosicaoConsolidada>();

            lista.Add(new PosicaoConsolidada
            {
                IdCliente = IdClienteConsulta,
                IdFundo = 43001,
                NomeFundo = "Fundo IPCA Based",
                ValorInvestido = 12098.00,
                PercentualCarteira = 12,
                DataAtualizacao = DateTime.Now
            });

            lista.Add(new PosicaoConsolidada
            {
                IdCliente = IdClienteConsulta,
                IdFundo = 43002,
                NomeFundo = "Fundo IBOV Based",
                ValorInvestido = 72098.00,
                PercentualCarteira = 72,
                DataAtualizacao = DateTime.Now
            });


            lista.Add(new PosicaoConsolidada
            {
                IdCliente = IdClienteConsulta,
                IdFundo = 43003,
                NomeFundo = "Fundo IGMP Based",
                ValorInvestido = 16098.00,
                PercentualCarteira = 16,
                DataAtualizacao = DateTime.Now
            });

            return lista;
        }

    }
}
