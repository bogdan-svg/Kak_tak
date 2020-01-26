using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Airport_panel
{
    class Program
    {
        struct Flight
        {
            public int number;
            public DateTime departure_time;
            public DateTime irrival_time;
            public string status;
            public string port_of_departure;
            public string port_of_arrival;
            public string airline;
            public char terminal;
        }
        public static void random_flight()
        {
            Random rnd = new Random();
            int flight_count = rnd.Next(10, 20);

            Flight[] flight = new Flight[flight_count];

            string[] status_type = { "check_in", "gate_closed", "arrived", "departed_at", "unknown", "canceled", "expected_at", "delayed", "in_flight" };

            string[] port_type = { "Atlanta_Airport", "Beijing_Airport", "Los_Angeles_Airport", "Tokyo_Airport", "Dubai_Airport" };

            string[] airline_type = { "Turkish_Аirlines", "Ukraine_Airlines", "Belavia_Airlines", "France_Airlines", "Austrian_Airlines" };

            char[] terminal_type = { 'A', 'B', 'C', 'D' };
            for (int i = 0; i < flight_count; i++)
            {
                flight[i].number = rnd.Next(100, 999);
                flight[i].status = status_type[rnd.Next(0, status_type.Length)];
                flight[i].port_of_departure = port_type[rnd.Next(0, port_type.Length)];
                flight[i].port_of_arrival = port_type[rnd.Next(0, port_type.Length)];
                flight[i].airline = airline_type[rnd.Next(0, airline_type.Length)];
                flight[i].terminal = terminal_type[rnd.Next(0, terminal_type.Length)];
                flight[i].departure_time = DateTime.Now.AddHours(rnd.Next(1, 12));
                flight[i].irrival_time = DateTime.Now.AddHours(rnd.Next(12, 24));
            }
            for (int i = 0; i < flight_count; i++)
            {
                Console.WriteLine("number: {0}\n port_of_departure: {2} \t departure_time: {5} \n port_of_arrival: {7} \t irrival_time: {6} \n airline: {3} \n status:{1} \n terminal: {4}\n  ",
                     flight[i].number, flight[i].status, flight[i].port_of_departure, flight[i].airline, flight[i].terminal, flight[i].departure_time, flight[i].irrival_time, flight[i].port_of_arrival);
            }

        }



        public static void search()
        {
            Random rnd = new Random();
            int flight_count = rnd.Next(1,9);

            Flight[] flight = new Flight[flight_count];

            string[] status_type = { "check_in", "gate_closed", "arrived", "departed_at", "unknown", "canceled", "expected_at", "delayed", "in_flight" };

            string[] port_type = { "Atlanta_Airport", "Beijing_Airport", "Los_Angeles_Airport", "Tokyo_Airport", "Dubai_Airport" };

            string[] airline_type = { "Turkish_Аirlines", "Ukraine_Airlines", "Belavia_Airlines", "France_Airlines", "Austrian_Airlines" };

            char[] terminal_type = { 'A', 'B', 'C', 'D' };
            for (int i = 0; i < flight_count; i++)
            {
                flight[i].number = rnd.Next(100, 999);
                flight[i].status = status_type[rnd.Next(0, status_type.Length)];
                flight[i].port_of_departure = port_type[rnd.Next(0, port_type.Length)];
                flight[i].port_of_arrival = port_type[rnd.Next(0, port_type.Length)];
                flight[i].airline = airline_type[rnd.Next(0, airline_type.Length)];
                flight[i].terminal = terminal_type[rnd.Next(0, terminal_type.Length)];
                flight[i].departure_time = DateTime.Now.AddHours(rnd.Next(1, 12));
                flight[i].irrival_time = DateTime.Now.AddHours(rnd.Next(12, 24));
            }

          

            for (int i = 0; i < flight_count; i++)
            {
                Console.WriteLine("number: {0}\n port_of_departure: {2} \t departure_time: {5} \n port_of_arrival: {7} \t irrival_time: {6} \n airline: {3} \n status:{1} \n terminal: {4}\n  ",
                     flight[i].number, flight[i].status, flight[i].port_of_departure, flight[i].airline, flight[i].terminal, flight[i].departure_time, flight[i].irrival_time, flight[i].port_of_arrival);
            }

            
            
            try
            {
                do
                {

                    Console.WriteLine("enter search : 1.number 2.status 3.port_of_departure 4.airline 5.exit");
                    try
                    {
                        int tt = int.Parse(Console.ReadLine());
                        switch (tt)
                        {
                            case 1:
                                Console.WriteLine("enter number");
                                int number = int.Parse(Console.ReadLine());
                                for (int i = 0; i < flight_count; i++)
                                {
                                    if (flight[i].number == number)
                                    {
                                        Console.WriteLine("number: {0}\n port_of_departure: {2} \t departure_time: {5} \n port_of_arrival: {7} \t irrival_time: {6} \n airline: {3} \n status:{1} \n terminal: {4}\n  ",
                                        flight[i].number, flight[i].status, flight[i].port_of_departure, flight[i].airline, flight[i].terminal, flight[i].departure_time, flight[i].irrival_time, flight[i].port_of_arrival);
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("enter status");
                                string status = Console.ReadLine();
                                for (int i = 0; i < flight_count; i++)
                                {
                                    if (flight[i].status == status)
                                    {
                                        Console.WriteLine("number: {0}\n port_of_departure: {2} \t departure_time: {5} \n port_of_arrival: {7} \t irrival_time: {6} \n airline: {3} \n status:{1} \n terminal: {4}\n  ",
                                        flight[i].number, flight[i].status, flight[i].port_of_departure, flight[i].airline, flight[i].terminal, flight[i].departure_time, flight[i].irrival_time, flight[i].port_of_arrival);
                                    }
                                }
                                break;
                            case 3:
                                Console.WriteLine("enter port of departure ");
                                string port_of_departure = Console.ReadLine();
                                for (int i = 0; i < flight_count; i++)
                                {
                                    if (flight[i].port_of_departure == port_of_departure)
                                    {
                                        Console.WriteLine("number: {0}\n port_of_departure: {2} \t departure_time: {5} \n port_of_arrival: {7} \t irrival_time: {6} \n airline: {3} \n status:{1} \n terminal: {4}\n  ",
                                        flight[i].number, flight[i].status, flight[i].port_of_departure, flight[i].airline, flight[i].terminal, flight[i].departure_time, flight[i].irrival_time, flight[i].port_of_arrival);
                                    }
                                }
                                Console.WriteLine("");
                                break;
                            case 4:
                                Console.WriteLine("enter port of departure ");
                                string airline = Console.ReadLine();
                                for (int i = 0; i < flight_count; i++)
                                {
                                    if (flight[i].airline == airline)
                                    {
                                        Console.WriteLine("number: {0}\n port_of_departure: {2} \t departure_time: {5} \n port_of_arrival: {7} \t irrival_time: {6} \n airline: {3} \n status:{1} \n terminal: {4}\n  ",
                                        flight[i].number, flight[i].status, flight[i].port_of_departure, flight[i].airline, flight[i].terminal, flight[i].departure_time, flight[i].irrival_time, flight[i].port_of_arrival);
                                    }
                                }
                                break;
                            case 5:
                                return;
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error" + e.Message);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           

        }








        public static void add_delete_editing()
        {
            Random rnd = new Random();
            int flight_count = 4; //rnd.Next(2, 5);

            Flight[] flight = new Flight[flight_count];

            string[] status_type = { "check_in", "gate_closed", "arrived", "departed_at", "unknown", "canceled", "expected_at", "delayed", "in_flight" };

            string[] port_type = { "Atlanta_Airport", "Beijing_Airport", "Los_Angeles_Airport", "Tokyo_Airport", "Dubai_Airport" };

            string[] airline_type = { "Turkish_Аirlines", "Ukraine_Airlines", "Belavia_Airlines", "France_Airlines", "Austrian_Airlines" };

            char[] terminal_type = { 'A', 'B', 'C', 'D' };
            for (int i = 0; i < flight_count; i++)
            {
                flight[i].number = rnd.Next(100, 999);
                flight[i].status = status_type[rnd.Next(0, status_type.Length)];
                flight[i].port_of_departure = port_type[rnd.Next(0, port_type.Length)];
                flight[i].port_of_arrival = port_type[rnd.Next(0, port_type.Length)];
                flight[i].airline = airline_type[rnd.Next(0, airline_type.Length)];
                flight[i].terminal = terminal_type[rnd.Next(0, terminal_type.Length)];
                flight[i].departure_time = DateTime.Now.AddHours(rnd.Next(1, 12));
                flight[i].irrival_time = DateTime.Now.AddHours(rnd.Next(12, 24));
            }
            for (int i = 0; i < flight_count; i++)
            {
                Console.WriteLine("number: {0}\n port_of_departure: {2} \t departure_time: {5} \n port_of_arrival: {7} \t irrival_time: {6} \n airline: {3} \n status:{1} \n terminal: {4}\n  ",
                     flight[i].number, flight[i].status, flight[i].port_of_departure, flight[i].airline, flight[i].terminal, flight[i].departure_time, flight[i].irrival_time, flight[i].port_of_arrival);
            }                       
            try
            {
                do
                {

                    Console.WriteLine("Please,  make your choice: 1. add  2. delete 3. editing 4. exit");
                    try
                    {
                        int mm = (int)uint.Parse(Console.ReadLine());
                        switch (mm)
                        {
                            case 1:
                                Console.WriteLine("кількість");
                                int bb = int.Parse(Console.ReadLine());
                                Flight[] add_flight = new Flight[bb];
                                for (int i = 0; i < bb; i++)
                                {
                                    add_flight[i].number = rnd.Next(100, 999);
                                    add_flight[i].status = status_type[rnd.Next(0, status_type.Length)];
                                    add_flight[i].port_of_departure = port_type[rnd.Next(0, port_type.Length)];
                                    add_flight[i].port_of_arrival = port_type[rnd.Next(0, port_type.Length)];
                                    add_flight[i].airline = airline_type[rnd.Next(0, airline_type.Length)];
                                    add_flight[i].terminal = terminal_type[rnd.Next(0, terminal_type.Length)];
                                    add_flight[i].departure_time = DateTime.Now.AddHours(rnd.Next(1, 12));
                                    add_flight[i].irrival_time = DateTime.Now.AddHours(rnd.Next(12, 24));
                                }
                                for (int i = 0; i < flight_count; i++)
                                {
                                    Console.WriteLine("number: {0}\n port_of_departure: {2} \t departure_time: {5} \n port_of_arrival: {7} \t irrival_time: {6} \n airline: {3} \n status:{1} \n terminal: {4}\n  ",
                                         flight[i].number, flight[i].status, flight[i].port_of_departure, flight[i].airline, flight[i].terminal, flight[i].departure_time, flight[i].irrival_time, flight[i].port_of_arrival);
                                }
                                for (int i = 0; i < bb; i++)
                                {
                                    Console.WriteLine("number: {0}\n port_of_departure: {2} \t departure_time: {5} \n port_of_arrival: {7} \t irrival_time: {6} \n airline: {3} \n status:{1} \n terminal: {4}\n  ",
                                         add_flight[i].number, add_flight[i].status, add_flight[i].port_of_departure, add_flight[i].airline, add_flight[i].terminal, add_flight[i].departure_time, add_flight[i].irrival_time, add_flight[i].port_of_arrival);
                                }
                                break;

                            case 2:
                                Console.WriteLine("nomer reisy");
                                int nn = int.Parse(Console.ReadLine());
                                for (int i = 0; i < flight_count; i++)
                                {
                                    if (nn == flight[i].number)
                                    {
                                        flight[i].number = 0;

                                    }
                                }
                                for (int i = 0; i < flight_count; i++)
                                {
                                    if (flight[i].number != 0)
                                    {
                                        Console.WriteLine("number: {0}\n port_of_departure: {2} \t departure_time: {5} \n port_of_arrival: {7} \t irrival_time: {6} \n airline: {3} \n status:{1} \n terminal: {4}\n  ",
                                             flight[i].number, flight[i].status, flight[i].port_of_departure, flight[i].airline, flight[i].terminal, flight[i].departure_time, flight[i].irrival_time, flight[i].port_of_arrival);
                                    }
                                }
                                break;

                            case 3:
                                
                                Console.WriteLine("enter number");
                                int number = int.Parse(Console.ReadLine());
                                Console.WriteLine(" enter an extraordinary siuation :");
                                string enter_for_extraordinary_situation = Console.ReadLine();
                                for (int i = 0; i < flight_count; i++)
                                {
                                    if (number == flight[i].number )
                                    {                                       
                                        Console.WriteLine("\nnumber: {0}\n port_of_departure: {2} \t departure_time: {5} \n port_of_arrival: {7} \t irrival_time: {6} \n airline: {3} \n status:{1} \n terminal: {4}  ",
                                             flight[i].number, flight[i].status, flight[i].port_of_departure, flight[i].airline, flight[i].terminal, flight[i].departure_time, flight[i].irrival_time, flight[i].port_of_arrival);


                                        Console.WriteLine($" extraordinary sinuation : {enter_for_extraordinary_situation}\n\n");
                                    }

                                    Console.WriteLine("number: {0}\n port_of_departure: {2} \t departure_time: {5} \n port_of_arrival: {7} \t irrival_time: {6} \n airline: {3} \n status:{1} \n terminal: {4}\n  ",
                                    flight[i].number, flight[i].status, flight[i].port_of_departure, flight[i].airline, flight[i].terminal, flight[i].departure_time, flight[i].irrival_time, flight[i].port_of_arrival);


                                }
                                

                                break;
                            case 4:
                                return;
                           
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error" + e.Message);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        

        

            static void Main(string[] args)
        {


            int a;
            try
            {
                do
                {

                    Console.WriteLine("Please,  make your choice:\n 1. Airport_panel \n 2. search\n 3. adding delete editing");
                    try
                    {
                        a = (int)uint.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:                                
                                random_flight();
                                break;
                            case 2:
                                search();
                                break;
                            case 3:
                                add_delete_editing();
                                Console.WriteLine("");
                                break;
                            case 4:
                                
                                Console.WriteLine("");
                                break;
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error" + e.Message);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

         
        }
       


    }
}
