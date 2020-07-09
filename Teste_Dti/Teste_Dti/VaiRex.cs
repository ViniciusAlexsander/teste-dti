using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Dti
{
    public class VaiRex:PetShop
    {
        protected double valorAumentoFinalSemana;

        public double ValorAumentoFinalSemana { get => valorAumentoFinalSemana; set => valorAumentoFinalSemana = value; }

        public VaiRex(string nome, double distancia, double precoDiaSemanaCaesPequenos, double precoDiaSemanaCaesGrandes, double valorAumentoFinalSemana) : base(nome, distancia, precoDiaSemanaCaesPequenos, precoDiaSemanaCaesGrandes)
        {
            this.valorAumentoFinalSemana = valorAumentoFinalSemana;
        }

        public override double calcPrecoCaes(int qntCaes, DateTime diaDaSemana, double precoDiaSemana)
        {
            double preco;
            preco = qntCaes * precoDiaSemana;
            
            if (diaDaSemana.DayOfWeek == DayOfWeek.Saturday || diaDaSemana.DayOfWeek == DayOfWeek.Sunday)
            { 
               preco = qntCaes * (ValorAumentoFinalSemana + precoDiaSemana);
            }
            return preco;
        }

        public override void calcPrecoFinal(int qntCaesPequenos, int qntCaesGrandes, double precoCaesPequenos, double precoCaesGrandes, DateTime diaDaSemana)
        {
            PrecoFinal = calcPrecoCaes(qntCaesPequenos, diaDaSemana, precoCaesPequenos) + calcPrecoCaes(qntCaesGrandes, diaDaSemana, precoCaesGrandes);
        }
    }
}
