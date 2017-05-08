using System;

namespace FiapInvest.Models
{
    public class PosicaoConsolidada
    {
        public DateTime DataAtualizacao { get; set; }
        public int IdCliente { get; set; }
        public int IdFundo { get; set; }
        public String NomeFundo { get; set; }
        public Double ValorInvestido { get; set; }
        public Double PercentualCarteira { get; set; }
        public String IconeFundo { get; set; }
    }
}
