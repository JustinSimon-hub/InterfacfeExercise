using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		
		public string NumOfTires{get; set;}
		public string VehicleColor {get; set;}
		public bool TintedWindows {get; set;}
		public bool VehicleModded {get; set;}
	}
}

 //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */