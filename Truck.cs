using System;
using System.Collections.Generic;
namespace InterfaceExercise
{
	public class Truck : ICompany, IVehicle
	{
	public string DrivenByHillbilly {get; set;}
	public string HasBed {get; set;}

	public string NumOfTires{get; set;}
		public string VehicleColor {get; set;}
		public bool TintedWindows {get; set;}
		public bool VehicleModded {get; set;}

		public string Logo {get; set;}
		public string Slogan {get; set;}

		
	}
}

