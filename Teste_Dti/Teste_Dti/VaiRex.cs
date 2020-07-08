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
        public override double calcPrecoCaesPequenos(int qntCaes, int diaDaSemana)
        {
            double precoFinalCaesPequenos;
            if (diaDaSemana >= 1 && diaDaSemana <= 5)
            {
                precoFinalCaesPequenos = qntCaes * PrecoDiaSemanaCaesPequenos;
                
            }
            else
            {
                precoFinalCaesPequenos = qntCaes * (valorAumentoFinalSemana + PrecoDiaSemanaCaesPequenos);
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
                precoFinalCaesGrandes = qntCaes * (valorAumentoFinalSemana + PrecoDiaSemanaCaesPequenos);
            }
            return precoFinalCaesGrandes;
        }
    }
}
