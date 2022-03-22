namespace Hephaestus
{
	partial class Hephaestus
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.densityTextField = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.calcbutton = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.fluidNameBox = new System.Windows.Forms.ComboBox();
			this.propType = new System.Windows.Forms.ComboBox();
			this.secondPropVal = new System.Windows.Forms.TextBox();
			this.enthalpyVal = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.vaporQuality = new System.Windows.Forms.Label();
			this.densityValue = new System.Windows.Forms.Label();
			this.pressureValue = new System.Windows.Forms.Label();
			this.entropyValue = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.temperatureValue = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.secondPropTextField = new System.Windows.Forms.Label();
			this.firstValProp = new System.Windows.Forms.TextBox();
			this.firstPropTextField = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// densityTextField
			// 
			this.densityTextField.AutoSize = true;
			this.densityTextField.Location = new System.Drawing.Point(293, 32);
			this.densityTextField.Name = "densityTextField";
			this.densityTextField.Size = new System.Drawing.Size(91, 25);
			this.densityTextField.TabIndex = 4;
			this.densityTextField.Text = "Kerapatan";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(293, 67);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 25);
			this.label6.TabIndex = 5;
			this.label6.Text = "Kualitas Uap";
			// 
			// calcbutton
			// 
			this.calcbutton.Location = new System.Drawing.Point(526, 280);
			this.calcbutton.Name = "calcbutton";
			this.calcbutton.Size = new System.Drawing.Size(112, 34);
			this.calcbutton.TabIndex = 7;
			this.calcbutton.Text = "Calculate";
			this.calcbutton.UseVisualStyleBackColor = true;
			this.calcbutton.Click += new System.EventHandler(this.button1_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 46);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(102, 25);
			this.label7.TabIndex = 8;
			this.label7.Text = "Fluida Kerja";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// fluidNameBox
			// 
			this.fluidNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.fluidNameBox.FormattingEnabled = true;
			this.fluidNameBox.Location = new System.Drawing.Point(163, 43);
			this.fluidNameBox.Name = "fluidNameBox";
			this.fluidNameBox.Size = new System.Drawing.Size(182, 33);
			this.fluidNameBox.TabIndex = 10;
			this.fluidNameBox.SelectedIndexChanged += new System.EventHandler(this.fluidNameBox_SelectedIndexChanged);
			// 
			// propType
			// 
			this.propType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.propType.FormattingEnabled = true;
			this.propType.Location = new System.Drawing.Point(163, 81);
			this.propType.Name = "propType";
			this.propType.Size = new System.Drawing.Size(182, 33);
			this.propType.TabIndex = 11;
			this.propType.SelectedIndexChanged += new System.EventHandler(this.propType_SelectedIndexChanged);
			// 
			// secondPropVal
			// 
			this.secondPropVal.Location = new System.Drawing.Point(163, 174);
			this.secondPropVal.Name = "secondPropVal";
			this.secondPropVal.Size = new System.Drawing.Size(150, 31);
			this.secondPropVal.TabIndex = 12;
			// 
			// enthalpyVal
			// 
			this.enthalpyVal.AutoSize = true;
			this.enthalpyVal.Location = new System.Drawing.Point(108, 106);
			this.enthalpyVal.Name = "enthalpyVal";
			this.enthalpyVal.Size = new System.Drawing.Size(54, 25);
			this.enthalpyVal.TabIndex = 16;
			this.enthalpyVal.Text = "kJ/kg";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.vaporQuality);
			this.groupBox1.Controls.Add(this.densityValue);
			this.groupBox1.Controls.Add(this.pressureValue);
			this.groupBox1.Controls.Add(this.entropyValue);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.enthalpyVal);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.temperatureValue);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.densityTextField);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(59, 320);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(579, 206);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nilai Properti";
			// 
			// vaporQuality
			// 
			this.vaporQuality.AutoSize = true;
			this.vaporQuality.Location = new System.Drawing.Point(449, 67);
			this.vaporQuality.Name = "vaporQuality";
			this.vaporQuality.Size = new System.Drawing.Size(27, 25);
			this.vaporQuality.TabIndex = 20;
			this.vaporQuality.Text = "%";
			// 
			// densityValue
			// 
			this.densityValue.AutoSize = true;
			this.densityValue.Location = new System.Drawing.Point(449, 32);
			this.densityValue.Name = "densityValue";
			this.densityValue.Size = new System.Drawing.Size(65, 25);
			this.densityValue.TabIndex = 19;
			this.densityValue.Text = "kg/m3";
			// 
			// pressureValue
			// 
			this.pressureValue.AutoSize = true;
			this.pressureValue.Location = new System.Drawing.Point(106, 32);
			this.pressureValue.Name = "pressureValue";
			this.pressureValue.Size = new System.Drawing.Size(39, 25);
			this.pressureValue.TabIndex = 18;
			this.pressureValue.Text = "kPa";
			// 
			// entropyValue
			// 
			this.entropyValue.AutoSize = true;
			this.entropyValue.Location = new System.Drawing.Point(106, 141);
			this.entropyValue.Name = "entropyValue";
			this.entropyValue.Size = new System.Drawing.Size(74, 25);
			this.entropyValue.TabIndex = 17;
			this.entropyValue.Text = "kJ/(kgK)";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 141);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 25);
			this.label8.TabIndex = 9;
			this.label8.Text = "Entropi";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 25);
			this.label4.TabIndex = 8;
			this.label4.Text = "Entalpi";
			// 
			// temperatureValue
			// 
			this.temperatureValue.AutoSize = true;
			this.temperatureValue.Location = new System.Drawing.Point(108, 67);
			this.temperatureValue.Name = "temperatureValue";
			this.temperatureValue.Size = new System.Drawing.Size(22, 25);
			this.temperatureValue.TabIndex = 15;
			this.temperatureValue.Text = "K";
			this.temperatureValue.Click += new System.EventHandler(this.temperatureValue_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 25);
			this.label3.TabIndex = 7;
			this.label3.Text = "Suhu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "Tekanan";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.secondPropTextField);
			this.groupBox2.Controls.Add(this.firstValProp);
			this.groupBox2.Controls.Add(this.firstPropTextField);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.propType);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.secondPropVal);
			this.groupBox2.Controls.Add(this.fluidNameBox);
			this.groupBox2.Location = new System.Drawing.Point(59, 37);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(579, 225);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Input";
			// 
			// secondPropTextField
			// 
			this.secondPropTextField.AutoSize = true;
			this.secondPropTextField.Location = new System.Drawing.Point(6, 177);
			this.secondPropTextField.Name = "secondPropTextField";
			this.secondPropTextField.Size = new System.Drawing.Size(90, 25);
			this.secondPropTextField.TabIndex = 15;
			this.secondPropTextField.Text = "Properti 2";
			// 
			// firstValProp
			// 
			this.firstValProp.Location = new System.Drawing.Point(163, 132);
			this.firstValProp.Name = "firstValProp";
			this.firstValProp.Size = new System.Drawing.Size(150, 31);
			this.firstValProp.TabIndex = 14;
			this.firstValProp.TextChanged += new System.EventHandler(this.firstValProp_TextChanged);
			// 
			// firstPropTextField
			// 
			this.firstPropTextField.AutoSize = true;
			this.firstPropTextField.Location = new System.Drawing.Point(6, 135);
			this.firstPropTextField.Name = "firstPropTextField";
			this.firstPropTextField.Size = new System.Drawing.Size(90, 25);
			this.firstPropTextField.TabIndex = 13;
			this.firstPropTextField.Text = "Properti 1";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 84);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(151, 25);
			this.label9.TabIndex = 12;
			this.label9.Text = "Properti Masukan";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 562);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.calcbutton);
			this.Name = "Form1";
			this.Text = "Kalkulator Properti Fluida";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private Label densityTextField;
		private Label label6;
		private Button calcbutton;
		private Label label7;
		private ComboBox fluidNameBox;
		private ComboBox propType;
		private TextBox secondPropVal;
		private Label enthalpyVal;
		private GroupBox groupBox1;
		private Label temperatureValue;
		private Label label8;
		private Label label4;
		private Label label3;
		private Label label2;
		private GroupBox groupBox2;
		private Label label9;
		private Label firstPropTextField;
		private Label secondPropTextField;
		private TextBox firstValProp;
		private Label pressureValue;
		private Label entropyValue;
		private Label vaporQuality;
		private Label densityValue;
	}
}