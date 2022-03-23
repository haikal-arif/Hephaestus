using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EngineeringUnits;
using SharpFluids;

namespace Hephaestus
{
	using TDDD = Tuple<Delegate, Delegate, Delegate>;
	using TSSS = Tuple<string, string, string>;
	internal class FluidPropertyPair
	{
		public static TSSS[] propertyPair =
		{
			new TSSS("Density & Specific Entropy", "Density (kg/m3)", "Entropy (kJ/kgK)"),
			new TSSS("Pressure & Temperature", "Pressure (kPa)", "Temperature (°C)"),
			new TSSS("Vapor quality & Temperature", "Quality (0-1)", "Temperature (°C)"),
			new TSSS("Pressure & Entropy", "Pressure (kPa)", "Entropy (kJ/kgK)"),

		};

		public static void UpdateProperty(Fluid workingFluid, int propertyIndex, double val1, double val2)
		{
			List<TDDD> propertiesTextField = new List<TDDD>
			{
				{new TDDD( workingFluid.UpdateDS, Density.FromKilogramPerCubicMeter, SpecificEntropy.FromKilojoulePerKilogramKelvin) },
				{new TDDD( workingFluid.UpdatePT, Pressure.FromKilopascal, Temperature.FromDegreesCelsius) },
				{new TDDD( workingFluid.UpdateXT, (double x) => {return x; }, Temperature.FromDegreesCelsius)},
				{new TDDD( workingFluid.UpdatePS, Pressure.FromKilopascal, SpecificEntropy.FromKilojoulePerKilogramKelvin)},
			};

			var prop1 = propertiesTextField[propertyIndex].Item2.DynamicInvoke(val1);
			var prop2 = propertiesTextField[propertyIndex].Item3.DynamicInvoke(val2);
			propertiesTextField[propertyIndex].Item1.DynamicInvoke(prop1, prop2);
		}

	}
}
