using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Teste_Dti
{
    public class ChowChawgas: PetShop
    {
        public ChowChawgas(string nome, double distancia, double precoDiaSemanaCaesPequenos, double precoDiaSemanaCaesGrandes) : base(nome, distancia, precoDiaSemanaCaesPequenos, precoDiaSemanaCaesGrandes)
        {

        }
        public override double calcPrecoCaesPequenos(int qntCaes, int diaDaSemana)
        {
            double precoFinalCaesPequenos;

            precoFinalCaesPequenos = qntCaes * PrecoDiaSemanaCaesPequenos;

            return precoFinalCaesPequenos;
        }
        public override double calcPrecoCaesGrandes(int qntCaes, int diaDaSemana)
        {
            double precoFinalCaesGrandes;

            precoFinalCaesGrandes = qntCaes * PrecoDiaSemanaCaesGrandes;

            return precoFinalCaesGrandes;
        }
    }
}

