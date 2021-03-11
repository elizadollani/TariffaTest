using System;

namespace TariffaTest
{
	public class Gestione
	{
		public static int TariffaA(int a, int totale)
		{

			if (a > 15)
			{
				totale = 15;
			}
			return totale;
		}
		public static int TariffaB(int a, int totale)
		{

			totale = a * 1;
			return totale;
		}
		public static double TariffaC(int a, double totale)
		{

			totale = a * 1.20;
			totale = totale - 1.20;
			return totale;
		}
	}
}
