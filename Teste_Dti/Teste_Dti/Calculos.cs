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
        
        public static int GetInt(string texto) 
        {
            string mensagemError = "Número invalido, por favor digite um número inteiro", input;
            int valor = 0;

            Console.Write(texto);
            input = Console.ReadLine();
            

            if(int.TryParse(input, out valor))
            {
                return valor;
            }
            else 
            {
                Console.Clear();
                Console.WriteLine(mensagemError);
                return GetInt(texto);
            }
        }
        public static string GetDate(string texto) 
        {
            string mensagemError = "Data invalida, por favor digite uma data correta no formato dd/mm/aaaa", input;
            DateTime data;


            Console.Write(texto);
            input = Console.ReadLine();
            

            if(DateTime.TryParseExact(input,"dd/MM/yyyy", CultureInfo.InvariantCulture,DateTimeStyles.None, out data))
            {
                    return input;
            }
            else 
            {
                Console.Clear();
                Console.WriteLine(mensagemError);
                return GetDate(texto);
            }
        }
        public static void CalcPetShop()
        {
            //criando os petshops
            PetShop meuCaninoFeliz = new MeuCaninoFeliz("Meu Canino Feliz", 2000, 20.00, 40.00, 0.2);
            PetShop vaiRex = new VaiRex("Vai Rex", 1.700, 15.00, 50.00, 5.00);
            PetShop chowChawgas = new ChowChawgas("ChowChawgas", 800, 30.00, 45.00);


            //pegando valores do console
            int qntCaesPequenos=0, qntCaesGrandes = 0, diaDaSemana;
            string dataString;
            bool continuar;
            
            //verificação da data
            dataString = GetDate("Digite a data que você deseja levar os cães ao petshop no formato dd/mm/aaaa: ");

            
           

            //verificação do número de cachorros
            qntCaesPequenos = GetInt("Digite a quantidade de cães de porte pequeno que deseja levar ao petshop: ");
            qntCaesGrandes = GetInt("Digite a quantidade de cães de porte grande que deseja levar ao petshop: ");


            //logica para pegar o dia da semana
            DateTime dateValue;

            dateValue = DateTime.Parse(dataString);
            
            diaDaSemana = ((int)dateValue.DayOfWeek);
            
            //Console.Clear();
            //Calculando o total em cada petshop
            meuCaninoFeliz.PrecoFinal = meuCaninoFeliz.calcPrecoCaesPequenos(qntCaesPequenos, diaDaSemana)+ meuCaninoFeliz.calcPrecoCaesGrandes(qntCaesGrandes,diaDaSemana);
            vaiRex.PrecoFinal = vaiRex.calcPrecoCaesPequenos(qntCaesPequenos, diaDaSemana) + vaiRex.calcPrecoCaesGrandes(qntCaesGrandes, diaDaSemana);
            chowChawgas.PrecoFinal = chowChawgas.calcPrecoCaesPequenos(qntCaesPequenos, diaDaSemana) + chowChawgas.calcPrecoCaesGrandes(qntCaesGrandes, diaDaSemana);

            PetShop[] petShopsArray = new PetShop[3] { meuCaninoFeliz, chowChawgas, vaiRex };

            //Realizar comparação
            for(int i = 0; i<petShopsArray.Length;i++)
            {
                PetShop aux;
                for(int j = 0; j< petShopsArray.Length - 1; j++)
                {
                    if (petShopsArray[j].PrecoFinal >= petShopsArray[j + 1].PrecoFinal && petShopsArray[j].Distancia > petShopsArray[j + 1].Distancia)
                    {
                        aux = petShopsArray[j];
                        petShopsArray[j] = petShopsArray[j + 1];
                        petShopsArray[j + 1] = aux;
                    }
                }
            }
            
            Console.WriteLine($"O canil com o melhor preço é o {petShopsArray[0].Nome} e o preço total dos banhos é de: {petShopsArray[0].PrecoFinal.ToString("C", CultureInfo.CurrentCulture)}");
        }
    }

}