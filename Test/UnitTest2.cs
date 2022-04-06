using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hephaestus;
using EngineeringUnits;
using SharpFluids;

namespace Test
{
	[TestClass]
	public class MapTest
	{
		Fluid testFluid = new Fluid(FluidList.Air);
		double pressureInput = 101.4;
		double qualityInput = 0;
		int propertyPairIndex = 4; // Pressure & Quality

		public MapTest()
		{
			Hephaestus.FluidPropertyPair.UpdateProperty(testFluid, propertyPairIndex, pressureInput, qualityInput);

		}

		[TestMethod]
		public void ParseTest()
		{
			var expectedValue = -19.7;
			double result;
			double.TryParse("-19,7", out result);
			Assert.AreEqual(expectedValue, result, 0.1);
		}

		[TestMethod]
		public void PressureTest()
		{
			var expectedPressure = 101.4e3;
			Assert.AreEqual(expectedPressure, testFluid.Pressure.SI, 1e3);
		}

		[TestMethod]
		public void TemperatureTest()
		{
			var expectedTemperature = -194.25;
			Assert.AreEqual(expectedTemperature, testFluid.Temperature.DegreesCelsius, 1);
		}
	}
}
