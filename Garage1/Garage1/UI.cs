using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1
{
    internal class UI
    {

        Garage<Vehicle> garage;

        public void MainMenu()
        {
            bool keepRuning = true;

            while (keepRuning)
            {
                Console.WriteLine("Enter choice Number ");
                Console.WriteLine("1)Creat NEW Garage");
                Console.WriteLine("0)Quit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        NewVehicle();
                        break;
                    case "0":
                        keepRuning = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect Input");
                        break;
                }
                Console.WriteLine("\n<Press any Botton to Continue>");
                Console.ReadKey();

            }

        }




        public void NewVehicle()
        {
            Console.WriteLine("Enter The Garage Size");
            int MaxCapacity = int.Parse(Console.ReadLine());

            garage = new Garage<Vehicle>(MaxCapacity);



            do
            {


                Console.WriteLine("1)Park Your Vehicle ");   

                Console.WriteLine("2)Unpark Your Vehicle ");
                Console.WriteLine("3)List the Parked Vehicles in The Garage ");
                Console.WriteLine("4)List 4 Wheels Vehicles in the Garge ");
                Console.WriteLine("0)exit to Main Menu ");


                string input2 = Console.ReadLine();

                switch (input2)
                {
                    case "1":
                        VehicleInput();
                        break;
                    case "2":
                        VehicleUnpark();
                        break;
                    case "3":
                        ListOfParkedCars();
                        break;
                    case "4":
                        break;
                    case "0":
                        return;
                }
            } while (true);
        }





        public void VehicleInput()
        {



            //Vehicle vehicle = new Vehicle("VehicleType", 6,"An",9);



            Console.WriteLine("Choose the Vehcile type  ");
            Console.WriteLine("1) Park a Car ");
            Console.WriteLine("2) Park a Buss ");
            Console.WriteLine("3) Park an Airplan");
            Console.WriteLine("4) Park a Motorcycle ");
            Console.WriteLine("5) Park a Boat ");


            string VehicleType = Console.ReadLine();

            Console.WriteLine("Enter Your Vehicle Number ");
            string RegNumber = Console.ReadLine();


            Console.WriteLine("Enter The Color");
            string Color = Console.ReadLine();

            string NrOfWheels = "";
            int NrOfWeelsCheck = 0;
            do
            {
                Console.WriteLine("Enter Number of your Vehicle Wheels ");
                NrOfWheels = Console.ReadLine();
                NrOfWeelsCheck = 0;
                if (int.TryParse(NrOfWheels, out NrOfWeelsCheck))
                {

                }
                else
                    Console.WriteLine("Incorrect Input");
            } while (int.TryParse(NrOfWheels, out NrOfWeelsCheck) == false);
            Vehicle vehicle = null;
            switch (VehicleType)
            {
                case "1":
                    Console.WriteLine("choose the fuel type");
                    string FuelType = Console.ReadLine();
                    vehicle = new Car(RegNumber, VehicleType, Color, NrOfWeelsCheck, FuelType);
                    break;

                case "2":
                    Console.WriteLine("choose the Number of Seats");
                    string NumberOfSeats = Console.ReadLine();
                    vehicle = new Car(RegNumber, VehicleType, Color, NrOfWeelsCheck, NumberOfSeats);
                    break;

                case "3":
                    Console.WriteLine("choose the Number of Engines");
                    string NumberOfEngines = Console.ReadLine();
                    vehicle = new Car(RegNumber, VehicleType, Color, NrOfWeelsCheck, NumberOfEngines);
                    break;

                case "4":
                    Console.WriteLine("How much Cylinder Volume");
                    string CylinderVolume = Console.ReadLine();
                    vehicle = new Car(RegNumber, VehicleType, Color, NrOfWeelsCheck, CylinderVolume);
                    break;
                case "5":
                    Console.WriteLine("choose the Boat Length");
                    string Length = Console.ReadLine();
                    vehicle = new Car(RegNumber, VehicleType, Color, NrOfWeelsCheck, Length);
                    break;



                default:
                    break;
            }
           
            garage.Add(vehicle);
            
        }

        public void VehicleUnpark()
        {
            Console.WriteLine("Enter the Registration Number");
            garage.Remove(Console.ReadLine());
        }

        public void ListOfParkedCars()
        {
            foreach (Vehicle a in garage)
            {
                Console.WriteLine("this is parked Cars Number " + a.RegNumber + " Color: "+ a.Color + "  Numbers Of wheel = " + a.NrOfWheels);
            }

        }


    }
}
