using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoDolar
{
	class ConversorDeMoeda
	{
		public static double Iof = 6.0;

		public static double DolarParaReal(double cotacao, double quantia)
		{
			double total = quantia * cotacao;
			return total + total * Iof / 100.0;
		}
	}
}
