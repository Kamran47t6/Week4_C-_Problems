using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1.properties
{
   public class Ship
    {
        public string shipnumber;
    
        public angle latitude;
        public angle longitude;
        public Ship(string shipnum, angle lati, angle longi)
        {
            shipnumber = shipnum;
            latitude = lati;
            longitude = longi;
        }
        public void print_position()
        {
            Console.WriteLine($"Ship is at {latitude} and {longitude}");
        }
        public void serial_number()
        {
            Console.WriteLine($"Ship serial number is {shipnumber}");
        }
        public void change_position(angle lati, angle longi)
        {
            latitude = lati;
            longitude = longi;
        }
    }
}
