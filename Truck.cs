using System;
namespace InterfaceExercise
{
	public class Truck : ICompany , IVehicle
	{
		public Truck()
		{
		}
		public string TruckNumOfLights {get; set;}
		public string TruckRearWheelDrive {get; set;}
        public string CompanyClassification { get;set; }
        public string CompanyLogo { get;set;}
        public string TrunkSize { get;set;}
        public string EngineSize {get ;set; }
        public string CarColor { get;set; }
        public string CarSizse { get;set; }
    }
}

