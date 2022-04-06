using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpFluids;
using EngineeringUnits;


namespace Test
{
	[TestClass]
	public class updatePTTest
	{

		private Pressure testPressure = new Pressure(14.7, EngineeringUnits.Units.PressureUnit.PoundForcePerSquareInch);
		private Temperature testTemperature = new Temperature(70, EngineeringUnits.Units.TemperatureUnit.DegreeFahrenheit);
		private Fluid testFluid = new Fluid(FluidList.Air);

		public updatePTTest()
		{
			testFluid.UpdatePT(testPressure, testTemperature);
		}

		[TestMethod]
		public void TemperatureTest()
		{

			testFluid.UpdatePT(testPressure, testTemperature);
			var expectedTemperature = 294.261;
			Assert.AreEqual(testFluid.Temperature.SI, expectedTemperature, 1);
		}

		[TestMethod]
		public void EnthalpyTest()
		{
			var expectedEnthalpy = 420e3;
			Assert.AreEqual(testFluid.Enthalpy.SI, expectedEnthalpy, 1e3);
		}

		[TestMethod]
		public void EntropyTest()
		{
			var expectedEntropy = 3867.0;
			Assert.AreEqual(testFluid.Entropy.SI, expectedEntropy, 5e2);
		}
	}

	[TestClass]
	public class updatePXTest
	{
		private Pressure testPressure = new Pressure(14.7, EngineeringUnits.Units.PressureUnit.PoundForcePerSquareInch);
		private double testQuality = 0;
		private Fluid testFluid = new Fluid(FluidList.Air);

		public updatePXTest()
		{
			testFluid.UpdatePX(testPressure, testQuality);
		}

		[TestMethod]
		public void TemperatureTest()
		{
			var expectedTemperature = 79; // Kelvin
			Assert.AreEqual(expectedTemperature, testFluid.Temperature.SI, 1);
		}

		[TestMethod]
		public void EnthalpyTest()
		{
			var expectedEnthalpy = 4.67; // J/kg
			Assert.AreEqual(expectedEnthalpy, testFluid.Enthalpy.SI, 1e-1);
		}

		[TestMethod]
		public void EntropyTest()
		{
			var expectedEntropy = 0.0595; // J/(kgK)
			Assert.AreEqual(expectedEntropy, testFluid.Entropy.SI, 1);
		}
	}

}