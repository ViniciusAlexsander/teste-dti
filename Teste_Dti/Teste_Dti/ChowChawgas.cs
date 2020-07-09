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

        public override double calcPrecoCaes(int qntCaes, DateTime diaDaSemana, double precoDiaSemana)
        {
            double preco;

            preco = qntCaes * precoDiaSemana;

            return preco;
        }

        public override void calcPrecoFinal(int qntCaesPequenos, int qntCaesGrandes, double precoCaesPequenos, double precoCaesGrandes, DateTime diaDaSemana)
        {
            PrecoFinal = calcPrecoCaes(qntCaesPequenos, diaDaSemana, precoCaesPequenos) + calcPrecoCaes(qntCaesGrandes, diaDaSemana, precoCaesGrandes);
        }
    }
}

