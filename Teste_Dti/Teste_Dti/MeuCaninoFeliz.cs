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
        public override double calcPrecoCaesPequenos(int qntCaes, int diaDaSemana)
        {
            double precoFinalCaesPequenos;
            if (diaDaSemana >= 1 && diaDaSemana <= 5)
            {
                precoFinalCaesPequenos = qntCaes * PrecoDiaSemanaCaesPequenos;
                
            }
            else
            {
                precoFinalCaesPequenos = qntCaes * PrecoDiaSemanaCaesPequenos;
                precoFinalCaesPequenos = precoFinalCaesPequenos + (precoFinalCaesPequenos * percAumentoFinalSemana);
            }
            return precoFinalCaesPequenos;
        }
        public override double calcPrecoCaesGrandes(int qntCaes, int diaDaSemana)
        {
            double precoFinalCaesGrandes;
            if (diaDaSemana >= 1 && diaDaSemana <= 5)
            {
                precoFinalCaesGrandes = qntCaes * PrecoDiaSemanaCaesGrandes;

            }
            else
            {
                precoFinalCaesGrandes = qntCaes * PrecoDiaSemanaCaesGrandes;
                precoFinalCaesGrandes = precoFinalCaesGrandes + (precoFinalCaesGrandes * percAumentoFinalSemana);
            }
            return precoFinalCaesGrandes;
        }
    }
}
