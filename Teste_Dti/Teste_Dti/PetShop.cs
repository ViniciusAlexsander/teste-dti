using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Dti
{
	public abstract class PetShop
	{
        protected string nome;
        protected double distancia;
        protected double precoDiaSemanaCaesPequenos;
        protected double precoDiaSemanaCaesGrandes;
        protected double precoFinal;


        public string Nome { get => nome; set => nome = value; }
        public double Distancia { get => distancia; set => distancia = value; }
        public double PrecoDiaSemanaCaesPequenos { get => precoDiaSemanaCaesPequenos; set => precoDiaSemanaCaesPequenos = value; }
        public double PrecoDiaSemanaCaesGrandes { get => precoDiaSemanaCaesGrandes; set => precoDiaSemanaCaesGrandes = value; }
        public double PrecoFinal { get => precoFinal; set => precoFinal = value; }

        public PetShop(string nome, double distancia, double precoDiaSemanaCaesPequenos, double precoDiaSemanaCaesGrandes)
        {
            this.nome = nome;
            this.distancia = distancia;
            this.precoDiaSemanaCaesPequenos = precoDiaSemanaCaesPequenos;
            this.precoDiaSemanaCaesGrandes = precoDiaSemanaCaesGrandes;

        }

        public abstract double calcPrecoCaesPequenos(int qntCaes, int diaSemana);
        public abstract double calcPrecoCaesGrandes(int qntCaes, int diaSemana);
    }
}
