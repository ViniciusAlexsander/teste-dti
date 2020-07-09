using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teste_Dti;

namespace Teste_Dti_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVaiRexVencendoPorDistancia()
        {
            PetShop meuCaninoFeliz = new MeuCaninoFeliz("Meu Canino Feliz", 2000, 20.00, 40.00, 0.2);
            PetShop vaiRex = new VaiRex("Vai Rex", 1700, 15.00, 50.00, 5.00);
            PetShop chowChawgas = new ChowChawgas("ChowChawgas", 800, 30.00, 45.00);

            DateTime data = new DateTime(2020, 07, 09);
            int qntCaesPequenos = 100, qntCaesGrandes = 50;

            meuCaninoFeliz.calcPrecoFinal(qntCaesPequenos, qntCaesGrandes, meuCaninoFeliz.PrecoDiaSemanaCaesPequenos, meuCaninoFeliz.PrecoDiaSemanaCaesGrandes, data);
            vaiRex.calcPrecoFinal(qntCaesPequenos, qntCaesGrandes, vaiRex.PrecoDiaSemanaCaesPequenos, vaiRex.PrecoDiaSemanaCaesGrandes, data);
            chowChawgas.calcPrecoFinal(qntCaesPequenos, qntCaesGrandes, chowChawgas.PrecoDiaSemanaCaesPequenos, chowChawgas.PrecoDiaSemanaCaesGrandes, data);
            List<PetShop> petShopsList = new List<PetShop> { meuCaninoFeliz, chowChawgas, vaiRex };

            var resultado = Calculos.ordenaList(petShopsList);
            Assert.AreEqual(vaiRex, resultado.First());

        }
        [TestMethod]
        public void TestMeuCaninoFelizVencendoPorMenorPreco()
        {
            PetShop meuCaninoFeliz = new MeuCaninoFeliz("Meu Canino Feliz", 2000, 20.00, 40.00, 0.2);
            PetShop vaiRex = new VaiRex("Vai Rex", 1700, 15.00, 50.00, 5.00);
            PetShop chowChawgas = new ChowChawgas("ChowChawgas", 800, 30.00, 45.00);

            DateTime data = new DateTime(2020, 07, 09);
            int qntCaesPequenos = 1, qntCaesGrandes = 1;

            meuCaninoFeliz.calcPrecoFinal(qntCaesPequenos, qntCaesGrandes, meuCaninoFeliz.PrecoDiaSemanaCaesPequenos, meuCaninoFeliz.PrecoDiaSemanaCaesGrandes, data);
            vaiRex.calcPrecoFinal(qntCaesPequenos, qntCaesGrandes, vaiRex.PrecoDiaSemanaCaesPequenos, vaiRex.PrecoDiaSemanaCaesGrandes, data);
            chowChawgas.calcPrecoFinal(qntCaesPequenos, qntCaesGrandes, chowChawgas.PrecoDiaSemanaCaesPequenos, chowChawgas.PrecoDiaSemanaCaesGrandes, data);
            List<PetShop> petShopsList = new List<PetShop> { meuCaninoFeliz, chowChawgas, vaiRex };

            var resultado = Calculos.ordenaList(petShopsList);
            Assert.AreEqual(meuCaninoFeliz, resultado.First());
        }
    }
}
