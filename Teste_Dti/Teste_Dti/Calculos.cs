using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Teste_Dti
{
    public static class Calculos
    {
        public static List<PetShop> ordenaList(List<PetShop> petShops)
        {
            petShops = petShops.OrderBy(p => p.PrecoFinal).ThenBy(p => p.Distancia).ToList();
            return petShops;
        }
        public static void CalcPetShop()
        {
            //criando os petshops
            PetShop meuCaninoFeliz = new MeuCaninoFeliz("Meu Canino Feliz", 2000, 20.00, 40.00, 0.2);
            PetShop vaiRex = new VaiRex("Vai Rex", 1700, 15.00, 50.00, 5.00);
            PetShop chowChawgas = new ChowChawgas("ChowChawgas", 800, 30.00, 45.00);

            //pegando valores do console
            int qntCaesPequenos = 0, qntCaesGrandes = 0;
            string input;
            DateTime data = new DateTime(0001,01,01);
            bool continuar;
            
            do
	        {
                try 
	            {	 
                    input = Console.ReadLine();
                    var array = input.Split(' ');

                    data = DateTime.Parse(array[0]);
                    qntCaesPequenos = int.Parse(array[1]);
                    qntCaesGrandes = int.Parse(array[2]);

                    continuar = true;
	            }
	            catch (Exception)
	            {
                    Console.Clear();
                    Console.WriteLine("Tente novamente com a entrada neste formato: <data> <quantidade de cães pequenos> <quantidade cães grandes>");
                    continuar = false;
	            }
	        } while (continuar == false);
                        
            //Calculando o total em cada petshop
            meuCaninoFeliz.calcPrecoFinal(qntCaesPequenos, qntCaesGrandes,meuCaninoFeliz.PrecoDiaSemanaCaesPequenos,meuCaninoFeliz.PrecoDiaSemanaCaesGrandes,data);
            vaiRex.calcPrecoFinal(qntCaesPequenos, qntCaesGrandes,vaiRex.PrecoDiaSemanaCaesPequenos,vaiRex.PrecoDiaSemanaCaesGrandes,data);
            chowChawgas.calcPrecoFinal(qntCaesPequenos,qntCaesGrandes,chowChawgas.PrecoDiaSemanaCaesPequenos,chowChawgas.PrecoDiaSemanaCaesGrandes,data);

            List<PetShop> petShopsList = new List<PetShop> { meuCaninoFeliz, chowChawgas, vaiRex };
            petShopsList = ordenaList(petShopsList); 
            
            Console.WriteLine($"{petShopsList.First().Nome} {petShopsList.First().PrecoFinal.ToString("C")}");
        }
    }
}