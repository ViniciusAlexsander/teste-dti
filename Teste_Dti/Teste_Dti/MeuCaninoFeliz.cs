using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Dti
{
    public class MeuCaninoFeliz:PetShop
    {
        protected double percAumentoFinalSemana;

        public double PercAumentoFinalSemana { get => percAumentoFinalSemana; set => percAumentoFinalSemana = value; }

        public MeuCaninoFeliz(string nome, double distancia, double precoDiaSemanaCaesPequenos, double precoDiaSemanaCaesGrandes, double percAumentoFinalSemana) : base(nome, distancia, precoDiaSemanaCaesPequenos, precoDiaSemanaCaesGrandes)
        {
            this.percAumentoFinalSemana = percAumentoFinalSemana;
        }


        public override double calcPrecoCaes(int qntCaes, DateTime diaDaSemana, double precoDiaSemana)
        {
            double preco;
            preco = qntCaes * precoDiaSemana;
             
            if (diaDaSemana.DayOfWeek == DayOfWeek.Saturday || diaDaSemana.DayOfWeek == DayOfWeek.Sunday)
            {
               preco = preco + (preco * percAumentoFinalSemana);   
            }
            return preco;
        }
        public override void calcPrecoFinal(int qntCaesPequenos, int qntCaesGrandes, double precoCaesPequenos, double precoCaesGrandes, DateTime diaDaSemana)
        {
            PrecoFinal = calcPrecoCaes(qntCaesPequenos, diaDaSemana, precoCaesPequenos) + calcPrecoCaes(qntCaesGrandes, diaDaSemana, precoCaesGrandes);
        }
    }
}
