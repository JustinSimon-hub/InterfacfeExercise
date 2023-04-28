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
            

            SUV suvobj = new SUV();
            Car carobj = new Car();
            Truck truckobj = new Truck();

            suvobj.CarColor = "red";
            suvobj.CarSizse = "large";
            suvobj.CompanyClassification = "LLC";
            suvobj.CompanyLogo = "ram";
            suvobj.EngineSize = "V6";
            suvobj.SUV6Cylinder = "is 6 cylinder";
            suvobj.SUVAllWheelDrive = "is all wheel drive";
            suvobj.TrunkSize = "large trunk";

            carobj.CarAllWheelDrive = "yes";
            carobj.CarColor = "blue";
            carobj.CarNumOfCylinders = "V8";
            carobj.CarSizse = "small";
            carobj.CompanyClassification = "sole proprietorship";
            carobj.CompanyLogo = "honda h";
            carobj.EngineSize = "medium";
            carobj.TrunkSize = "small trunk";

            truckobj.CarColor = "green";
            truckobj.CarSizse = "huge";
            truckobj.CompanyClassification = "company";
            truckobj.CompanyLogo = "ford";
            truckobj.EngineSize = "uniquely sized";
            truckobj.TruckNumOfLights = "6";
            truckobj.TruckRearWheelDrive = "rear wheel drive";
            truckobj.TrunkSize = "has bed";


            List<SUV> listofsuv = new List<SUV>();
            listofsuv.Add(suvobj);
            List<Car> listofcar = new List<Car>();
            listofcar.Add(carobj);
            List<Truck> listoftruck = new List<Truck>();
            listoftruck.Add(truckobj);


            

            foreach(var car in listofsuv)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"{car.CarColor},{car.CarSizse},{car.EngineSize},{car.CompanyClassification},{car.CompanyLogo},{car.EngineSize},{car.SUV6Cylinder},{car.SUVAllWheelDrive},{car.TrunkSize}");
            }
            foreach(var car in listofcar)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"{car.CarColor},{car.CarSizse},{car.EngineSize},{car.CompanyClassification},{car.CompanyLogo},{car.EngineSize},{car.CarNumOfCylinders},{car.CarAllWheelDrive},{car.TrunkSize}");
            }
            foreach(var car in listoftruck)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"{car.CarColor},{car.CarSizse},{car.EngineSize},{car.CompanyClassification},{car.CompanyLogo},{car.EngineSize},{car.TruckNumOfLights},{car.TruckRearWheelDrive},{car.TrunkSize}");
            }




        }
    }
}