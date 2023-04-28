using System;
namespace InterfaceExercise
{
	public class SUV : ICompany , IVehicle
	{
		public SUV()
		{
		}
		public string SUVAllWheelDrive {get; set;}
		public string SUV6Cylinder {get; set;}
        public string CompanyClassification {get;set;  }
        public string CompanyLogo {  get;set;}
        public string TrunkSize { get;set; }
        public string EngineSize { get;set; }
        public string CarColor { get;set;}
        public string CarSizse { get;set; }
    }
}

