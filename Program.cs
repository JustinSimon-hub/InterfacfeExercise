using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
           //Instantiation of each object in the class
           SUV suv = new SUV();
           Truck truck = new Truck();
           Car car = new Car();
          
           suv.AllWheelDrive = "Has all wheel drive";
           suv.LargeTires = "Has large tires";
           suv.Logo = "Chrysler";
           suv.NumOfTires = "4 tires";
           suv.Slogan = "We go farther";
           suv.TintedWindows = false;
           suv.VehicleColor = "Black";
           suv.VehicleModded = false;

           truck.DrivenByHillbilly = "Driven by hillbilly";
           truck.HasBed = "does have bed ";
           truck.Logo = "Ford";
           truck.NumOfTires = "3and a half";
           truck.Slogan = "Built tough";
           truck.TintedWindows = false;
           truck.VehicleColor = "White";
           truck.VehicleModded = false;

           car.Logo = "Honda";
           car.NumOfTires = "4 tires";
           car.Slogan = "We get you there";
           car.TintedWindows = true;
           car.TrunkSize = "small";
           car.TypeOfCar = "Coupe";
           car.VehicleColor = "grey";
           car.VehicleModded = true;
           //list of each object type and adds the properties to it 
           List<Car> carlist = new List<Car> {car};
           List<Truck> trucklist = new List<Truck>{truck};
           List<SUV> suvlist = new List<SUV>{suv};
           //Iterates through the list of each objecrt and adds them to a sentence in the console
           foreach( var i in carlist)
           {
            Console.WriteLine($"The car is a  {car.Logo} and has {car.NumOfTires} and the slogan of the car is {car.Slogan} and the status of its tint windows is {car.TintedWindows}  with a {car.TrunkSize} trunk size and is a  {car.TypeOfCar} and  {car.VehicleColor} and is {car.VehicleModded} modded.");
           }
           Console.WriteLine("********************");
           foreach(var i in trucklist)
           {
            Console.WriteLine($"The car is {truck.DrivenByHillbilly} and has a {truck.HasBed} and is a {truck.Logo} with {truck.NumOfTires} and the slogan of the company is {truck.Slogan}{truck.TintedWindows} and is {truck.VehicleColor} and the status of its modding is {truck.VehicleModded}.");
           }
           Console.WriteLine("*********************");
           foreach(var i in suvlist)
           {
            Console.WriteLine($" The SUV is {suv.AllWheelDrive} and has {suv.LargeTires} and the brand is {suv.Logo} and has {suv.NumOfTires} and the company slogan is {suv.Slogan} and the tinted window is {suv.TintedWindows} and is {suv.VehicleColor} and the modding status is {suv.VehicleModded}.");
           }

        }
    }
}
