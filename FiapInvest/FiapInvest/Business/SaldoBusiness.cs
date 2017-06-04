using FiapInvest.Models;
using FiapInvest.Services;
using System.Collections.Generic;

namespace FiapInvest.Business
{
    public class SaldoBusiness
    {
        public IList<SaldoFundo> consultarSaldo(int IdClienteConsulta)
        {
            return new SaldoService().consultarSaldo(IdClienteConsulta);
        }
    }

}
