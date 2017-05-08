using FiapInvest.DataAccessLayer;
using FiapInvest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapInvest.Business
{
    public class ConsultaSaldoBusiness
    {
        public IList<ConsultaSaldoModel> ConsultaSaldo(int IdClienteConsulta)
        {
            ConsultaSaldoDAL consultaSaldoDAL = new ConsultaSaldoDAL();
            return consultaSaldoDAL.ConsultaSaldo(IdClienteConsulta);           
        }
    }
}
