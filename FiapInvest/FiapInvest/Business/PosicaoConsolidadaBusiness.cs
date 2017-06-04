using System;
using System.Collections.Generic;
using FiapInvest.DataAccessLayer;
using FiapInvest.Models;
using FiapInvest.Services;

namespace FiapInvest.Business
{
    public class PosicaoConsolidadaBusiness
    {

        public IList<PosicaoConsolidada> ConsultarPosicaoConsolidada(int IdClienteConsulta)
        {
            var diasSemAtualizacao = 0;
            PosicaoConsolidadaDAL dal = new PosicaoConsolidadaDAL();
            PosicaoConsolidadaService service = new PosicaoConsolidadaService();

            IList<PosicaoConsolidada> listaPosicao = dal.ConsultarPosicaoConsolidada(IdClienteConsulta);
            if ( listaPosicao != null && listaPosicao.Count > 0 )
            {
                diasSemAtualizacao = (DateTime.Now - listaPosicao[0].DataAtualizacao).Days;
            } 

            if ( diasSemAtualizacao > 0 )
            {
                dal.DeletarPosicaoConsolidada(IdClienteConsulta);
                listaPosicao = service.ConsultarPosicaoConsolidada(IdClienteConsulta);
                dal.GravarPosicaoConsolidada(IdClienteConsulta, listaPosicao);
            }

            return listaPosicao;
        }

    }
}
