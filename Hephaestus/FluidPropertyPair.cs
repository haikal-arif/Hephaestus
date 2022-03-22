using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hephaestus
{
	internal class FluidPropertyPair
	{
		public static readonly Dictionary<string, Tuple<string, string>> propertiesTextField = new Dictionary<string, Tuple<string, string>>
		{
			{"Kerapatan & Entropi", new Tuple<string, string>("Kerapatan (kg/m3)", "Entropi (kJ/kg K)") },
			{"Tekanan & Suhu", new Tuple<string, string>("Tekanan (kPa)", "Suhu (C)") },
			{"Kualitas uap & Suhu", new Tuple<string, string>("Kualitas Uap", "Suhu (C)")}
		};
	}
}
