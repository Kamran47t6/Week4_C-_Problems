using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using problem1.properties;
namespace problem1
{
    class Program
    {
      static  List<Ship> ships = new List<Ship>();
        static void Main(string[] args)
        {
          
            int choise = 0;
            while (choise != 5)
            {
                Console.WriteLine("Press 1 to ADD Ship :");
                Console.WriteLine("Press 2 to View Ship position:");
                Console.WriteLine("Press 3 to View Ship Serial Number:");
                Console.WriteLine("Press 4 to change Ship Position:");
                Console.WriteLine("Press 5 to Exit :");
                choise = int.Parse(Console.ReadLine());
                if (choise == 1)
                {
                    Addship();
                }
                else if (choise == 2)
                {
                    viewshipPosition();
                }
                else if (choise == 3)
                {
                    viewship_serialnum();
                }
                else if (choise == 4)
                {
                    changeShipPosition();
                }
                else if (choise == 5)
                {

                }




            }
        }
        static void Addship()
        {
            Console.WriteLine("Enter Ship number :");
            string shipnumber = Console.ReadLine();
            Console.WriteLine("ENter ship Latitude :");

            Console.WriteLine("Enter latitude degree : ");
            int latdegr = int.Parse(Console.ReadLine());
            Console.WriteLine("ENter latitude minute :");
            float latmin =float.Parse( Console.ReadLine());
            Console.WriteLine("Enter latitude direction :");
            char latdirect = char.Parse(Console.ReadLine());
            angle latitude = new angle(latdegr, latmin, latdirect);
              
           
            Console.WriteLine("ENter ship longitude :");
            Console.WriteLine("ENter longitude degree :");
            int londeg = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter lognitude minute :");
            float longmin = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter longitude direction :");
            char longdirec = char.Parse(Console.ReadLine());
            angle longitude = new angle(londeg, longmin, longdirec);
            Ship newship = new Ship(shipnumber, latitude, longitude);
            ships.Add(newship);
            Console.WriteLine("Ship added successfully...");
        }
        static void viewshipPosition()
        {
            Console.WriteLine("Enter Ship Serial Number to find its position:");
            string number = Console.ReadLine();
            Ship ship = ships.Find(s => s.shipnumber == number);
            if (ship != null)
            {
                Console.WriteLine("Ship is at {0} and {1}", ship.latitude.ToString(), ship.longitude.ToString());
            }
            else
            {
                Console.Write("Ship not found !");
            }
        }
        static void changeShipPosition()
        {
            Console.WriteLine("ENter Ship's serial number whose position you want to change: ");
            string number = Console.ReadLine();
            Ship ship = ships.Find(s => s.shipnumber == number);
            if (ship != null)
            {
                Console.WriteLine("Enter ship latitude :");
                string latitude = GetAngle();
                Console.WriteLine("Enter ship longitude :");
                string longitude = GetAngle();
                string[] latitudeParts = latitude.Split(' ');
                int latitudeDegrees = int.Parse(latitudeParts[0]);
                float latitudeMinutes = float.Parse(latitudeParts[1]);
                char latitudeDirection = char.Parse(latitudeParts[2]);
                angle latitudee = new angle(latitudeDegrees, latitudeMinutes, latitudeDirection);

                string[] longitudeParts = longitude.Split(' ');
                int longitudeDegrees = int.Parse(longitudeParts[0]);
                float longitudeMinutes = float.Parse(longitudeParts[1]);
                char longitudeDirection = char.Parse(longitudeParts[2]);
                angle longitudee = new angle(longitudeDegrees, longitudeMinutes, longitudeDirection);
                ship.latitude = latitudee;
                ship.longitude = longitudee;
                Console.WriteLine("Ships position updated successfully!");
            }
            else
            {
                Console.WriteLine("Ship not found!");
            }
        }
        static string GetAngle()
        {
            Console.WriteLine("Enter Latitude Degree :");
            int degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude Minute :");
            float minute = float.Parse(Console.ReadLine());
            Console.WriteLine("ENter latitude Direction :");
            char direction = char.Parse(Console.ReadLine());
            angle ang = new angle(degree, minute, direction);
            return ang.ToString();
        }
        static void viewship_serialnum()
        {
            Console.WriteLine("Enter the ship latitude :");
            string shiplat = Console.ReadLine();
            angle latitude = angle.FromString(shiplat);
            Console.WriteLine("ENter the ship longitude :");
            string shiplongi = Console.ReadLine();
            angle longitude = angle.FromString(shiplongi);
            Ship ship = ships.FirstOrDefault(s => s.latitude == latitude && s.longitude == longitude);
            if (ship != null) 
            {
                Console.WriteLine($"SHip serial number is {ship.shipnumber}");
            }
            else
            {
                Console.WriteLine("Ship not found!");
            }
        }
        
    }
}
