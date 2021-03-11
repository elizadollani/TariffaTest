using Microsoft.VisualStudio.TestTools.UnitTesting;
using TariffaTest;

namespace TestGesione
{
	[TestClass]
	public class UnitTest1
	{
		[TestClass]
		public class GestioneTest
		{
			[TestMethod]
			public void TestTariffaA()
			{
				int ore = 16;
				int tariffa1 = 15;
				int rispostaAspettata = 15;
				int rispostaEffettiva = Gestione.TariffaA(ore, tariffa1);
				Assert.AreEqual(rispostaAspettata, rispostaEffettiva);
			}
			[TestMethod]
			public void TestTariffaB()
			{
				int ore = 7;
				int tariffa2 = 7;
				int rispostaAspettata = 7;
				int rispostaEffettiva = Gestione.TariffaB(ore, tariffa2);
				Assert.AreEqual(rispostaAspettata, rispostaEffettiva);
			}
			[TestMethod]
			public void TestTariffaC()
			{
				int ore = 10;
				double tariffa3 = 10.8;
				double rispostaAspettata = 10.8;
				double rispostaEffettiva = Gestione.TariffaC(ore, tariffa3);
				Assert.AreEqual(rispostaAspettata, rispostaEffettiva);
			}

		}
	}
}
