using System;
namespace InterfaceExercise
{
	public class Car : ICompany , IVehicle
	{
		public Car()
		{
		}
		public string CarAllWheelDrive {get; set;}
		public string CarNumOfCylinders {get; set;}
        public string CompanyClassification { get;set; }
        public string CompanyLogo { get; set; }
        public string TrunkSize {get; set; }
        public string EngineSize { get; set; }
        public string CarColor {  get;set;}
        public string CarSizse { get;set; }
    }
}

