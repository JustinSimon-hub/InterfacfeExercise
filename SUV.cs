using System;
namespace InterfaceExercise
{
	public class SUV : ICompany, IVehicle
	{
		public string AllWheelDrive {get; set;}
		public string LargeTires {get; set;}

		public string NumOfTires{get; set;}
		public string VehicleColor {get; set;}
		public bool TintedWindows {get; set;}
		public bool VehicleModded {get; set;}

		public string Logo {get; set;}
		public string Slogan {get; set;}
	}

	}


