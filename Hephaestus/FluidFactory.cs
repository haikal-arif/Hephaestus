using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpFluids;

namespace Hephaestus
{
	public class FluidFactory
	{
		private static readonly Dictionary<string, FluidList> fluidList = new()
		{
			{ "Air", FluidList.Water },
			{ "R134a", FluidList.R134a },
			{ "R404a", FluidList.R404A },
			{ "Udara", FluidList.Air }
		};

		public static Fluid? Create(string fluidName)
		{
			return fluidList.ContainsKey(fluidName) ? new Fluid(fluidList[fluidName]) : null;
		}

		public static readonly List<string> FluidListKeys = new(fluidList.Keys);
	}
}
