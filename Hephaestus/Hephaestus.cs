namespace Hephaestus
{
	public partial class Hephaestus : Form
	{
		
		public Hephaestus()
		{
			InitializeComponent();
			Form1_Load();
		}

		private void Form1_Load()
		{
			foreach (SharpFluids.FluidList fluid in (SharpFluids.FluidList[])Enum.GetValues(typeof(SharpFluids.FluidList)))
			{
				_ = fluidNameBox.Items.Add(fluid.ToString());
			}
			foreach(string fluidProps in FluidPropertyPair.propertiesTextField.Keys)
			{
				_ = propType.Items.Add(fluidProps);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (fluidNameBox.SelectedIndex == -1)
			{
				_ = MessageBox.Show("Choose working fluid");
				return;
			}
			SharpFluids.Fluid workingfluid = new((SharpFluids.FluidList)fluidNameBox.SelectedIndex);

			if(propType.SelectedIndex == -1)
			{
				_ = MessageBox.Show("Choose property pair");
				return ;
			}

			switch (propType.Text)
			{
				case "Kerapatan & Entropi":
					workingfluid.UpdateDS(
						EngineeringUnits.Density.FromKilogramPerCubicMeter(double.Parse(firstPropVal.Text)),
						EngineeringUnits.SpecificEntropy.FromKilojoulePerKilogramKelvin(double.Parse(secondPropVal.Text)));
					break;
				case "Tekanan & Suhu":
					workingfluid.UpdatePT(
						EngineeringUnits.Pressure.FromKilopascal(double.Parse(firstPropVal.Text)),	
						EngineeringUnits.Temperature.FromDegreesCelsius(double.Parse(secondPropVal.Text))
						);
					break;
				case "Kualitas uap & Suhu":
					workingfluid.UpdateXT(double.Parse(firstPropVal.Text),
						EngineeringUnits.Temperature.FromDegreesCelsius(double.Parse(secondPropVal.Text)));
					break;
				case "Tekanan & Entropi":
					workingfluid.UpdatePS(
						EngineeringUnits.Pressure.FromKilopascal(double.Parse(firstPropVal.Text)),
						EngineeringUnits.SpecificEntropy.FromKilojoulePerKilogramKelvin(double.Parse(secondPropVal.Text))
						);
					break ;
				default:
					_ = MessageBox.Show("Pilih pasangan properti");
					return;
			}

			pressureValue.Text =  workingfluid.Pressure.ToUnit(EngineeringUnits.Units.PressureUnit.Kilopascal).ToString();
			temperatureValue.Text = workingfluid.Temperature.ToUnit(EngineeringUnits.Units.TemperatureUnit.DegreeCelsius).ToString();
			enthalpyVal.Text = workingfluid.Enthalpy.ToUnit(EngineeringUnits.Units.SpecificEnergyUnit.KilojoulePerKilogram).ToString();
			entropyValue.Text = workingfluid.Entropy.ToUnit(EngineeringUnits.Units.SpecificEntropyUnit.KilojoulePerKilogramKelvin).ToString();
			densityValue.Text = workingfluid.Density.ToString();
			vaporQuality.Text = workingfluid.Quality.ToString();
		}

		private void fluidNameBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void temperatureValue_Click(object sender, EventArgs e)
		{

		}

		

		private void propType_SelectedIndexChanged(object sender, EventArgs e)
		{
			firstPropTextField.Text = FluidPropertyPair.propertiesTextField[propType.Text].Item1;
			secondPropTextField.Text = FluidPropertyPair.propertiesTextField[propType.Text].Item2;
		}

		private void firstValProp_TextChanged(object sender, EventArgs e)
		{

		}
	}
}