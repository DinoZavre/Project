using MyProjectGit.BL;
using MyProjectGit.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "please select an action:");
            Console.WriteLine("1. Create new flight.");
            Console.WriteLine("2. ");
            string action = Console.ReadLine();
            FlightRepository flightRespository = new FlightRepository();
            FlightServise flightService = new FlightServise(flightRespository);
            switch (action)
            {
                case "1":
                    Console.WriteLine("Enter Number");
                    string number = Console.ReadLine();

                    Console.WriteLine("departure time");
                    string departureTimeInput = Console.ReadLine();
                    DateTime departureTime = DateTime.Parse(departureTimeInput);

                    Console.WriteLine("departure time");
                    string arrivalTimeInput = Console.ReadLine();
                    DateTime arrivelTime = DateTime.Parse(arrivalTimeInput);

                    Console.WriteLine("departure");
                    string departure = Console.ReadLine();

                    Console.WriteLine("Destination");
                    string destination = Console.ReadLine();



                    break;
                    


            }
        }
    }
}
