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
			foreach (var fluidProps in FluidPropertyPair.propertyPair)
			{
				_ = propType.Items.Add(fluidProps.Item1);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (fluidNameBox.SelectedIndex == -1)
			{
				_ = MessageBox.Show("Choose working fluid");
				return;
			}
			
			if(propType.SelectedIndex == -1)
			{
				_ = MessageBox.Show("Choose property pair");
				return ;
			}
			
			SharpFluids.Fluid workingfluid = new((SharpFluids.FluidList)fluidNameBox.SelectedIndex);
			double firstVal;
			double secondVal;

			if(!double.TryParse(firstPropVal.Text,out firstVal) || !double.TryParse(secondPropVal.Text, out secondVal))
			{
				_ = MessageBox.Show("Input invalid, please input valid number value");
				return;
			}

			FluidPropertyPair.UpdateProperty(workingfluid, propType.SelectedIndex, firstVal, secondVal);

			pressureValue.Text = String.Format($"{workingfluid.Pressure.Kilopascal:0.##} kPa");
			temperatureValue.Text = String.Format($"{workingfluid.Temperature.DegreesCelsius:0.##} °C") ;
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
			firstPropTextField.Text = FluidPropertyPair.propertyPair[propType.SelectedIndex].Item2;
			secondPropTextField.Text = FluidPropertyPair.propertyPair[propType.SelectedIndex].Item3;
		}

		private void firstValProp_TextChanged(object sender, EventArgs e)
		{

		}

		private void pressureValue_Click(object sender, EventArgs e)
		{
			pressureValue.Focus();
		}

		private void Hephaestus_Load(object sender, EventArgs e)
		{

		}

		private void Hephaestus_KeyDown(object sender, KeyEventArgs e)
		{
			if (label1.ContainsFocus && e.Control && e.KeyCode == Keys.C)
				Clipboard.SetText(label1.Text);
		}
	}
}