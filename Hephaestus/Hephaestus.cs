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
			foreach(string fluid in FluidFactory.FluidListKeys)
			{
				_ = fluidNameBox.Items.Add(fluid);
			}
			foreach(string fluidProps in FluidPropertyPair.propertiesTextField.Keys)
			{
				_ = propType.Items.Add(fluidProps);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string workingFluidName = fluidNameBox.Text;
			SharpFluids.Fluid? workingfluid = FluidFactory.Create(workingFluidName);
			if (workingfluid is null)
			{
				_ = MessageBox.Show("Pilih fluida kerja");
				return;
			}

			string inputPropType = propType.Text;
			switch (inputPropType)
			{
				case "Kerapatan & Entropi":
					workingfluid.UpdateDS(
						EngineeringUnits.Density.FromKilogramPerCubicMeter(double.Parse(firstValProp.Text)),
						EngineeringUnits.SpecificEntropy.FromKilojoulePerKilogramKelvin(double.Parse(secondPropVal.Text)));
					break;
				case "Tekanan & Suhu":
					workingfluid.UpdatePT(
						EngineeringUnits.Pressure.FromKilopascal(double.Parse(firstValProp.Text)),	
						EngineeringUnits.Temperature.FromDegreesCelsius(double.Parse(secondPropVal.Text))
						);
					break;
				case "Kualitas uap & Suhu":
					workingfluid.UpdateXT(double.Parse(firstValProp.Text),
						EngineeringUnits.Temperature.FromDegreesCelsius(double.Parse(secondPropVal.Text)));
					break;
				default:
					_ = MessageBox.Show("Pilih pasangan properti");
					return;
			}

			pressureValue.Text =  workingfluid.Pressure.ToUnit(EngineeringUnits.Units.PressureUnit.Kilopascal).ToString();
			temperatureValue.Text = workingfluid.Temperature.ToString();
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