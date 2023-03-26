using System;
namespace InterfaceExercise
{
	public class Car : ICompany, IVehicle
	{
		public string TrunkSize {get; set;}
		public string TypeOfCar {get; set;}

		public string NumOfTires{get; set;}
		public string VehicleColor {get; set;}
		public bool TintedWindows {get; set;}
		public bool VehicleModded {get; set;}

		public string Logo {get; set;}
		public string Slogan {get; set;}
	}
}

