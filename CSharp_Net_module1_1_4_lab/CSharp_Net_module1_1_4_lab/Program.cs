using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {
        // 1) declare enum ComputerType
        enum ComputerType {Desktop,Laptop,Server};

        // 2) declare struct Computer
        struct Computer
        {
            public int CPU;
            public double Frequency;
            public int Memory;
            public int HDD;
            public ComputerType Type;
        }
        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)
            Computer[][] jagged_array = new Computer[4][];




            // 4) set the size of every array in jagged array (number of computers)
            jagged_array[0] = new Computer[5];
            jagged_array[1] = new Computer[3];
            jagged_array[2] = new Computer[5];
            jagged_array[3] = new Computer[4];


            // 5) initialize array
            // Note: use loops and if-else statements
            for (int j = 0 ; j < 4; j++)
            for (int i = 0; i < 5; i++)
            {
                    if ((j == 0 & i < 2) | (j == 2 & i < 3) | (j == 3 & i < 1))
                    {
                        jagged_array[j][i].Type = ComputerType.Desktop;
                        jagged_array[j][i].CPU = 4;
                        jagged_array[j][i].Frequency = 2.5;
                        jagged_array[j][i].Memory = 6;
                        jagged_array[j][i].HDD = 500;
                    }
                    if ((j == 0 & i > 1 & i < 5) | (j == 1 & i < 3) | (j == 2 & i > 2 & i < 5) | (j == 3 & i == 1))
                    {
                        jagged_array[j][i].Type = ComputerType.Laptop;
                        jagged_array[j][i].CPU = 2;
                        jagged_array[j][i].Frequency = 1.7;
                        jagged_array[j][i].Memory = 4;
                        jagged_array[j][i].HDD = 250;
                    }
                    if ((j == 0 & i == 4) | (j == 3 & i > 1 & i < 4))
                    {
                        jagged_array[j][i].Type = ComputerType.Server;
                        jagged_array[j][i].CPU = 8;
                        jagged_array[j][i].Frequency = 3;
                        jagged_array[j][i].Memory = 16;
                        jagged_array[j][i].HDD = 2048;
                    }
            }

            // 6) count total number of every type of computers
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)
           
                    int d = 0, l = 0, s = 0, a = 0;
                    for (int j = 0; j < jagged_array.Length; j++)
                        for (int i = 0; i < jagged_array[j].Length; i++)
                        {
                            a++;
                            switch (jagged_array[j][i].Type)
                            {
                                case ComputerType.Desktop:
                                    d++;
                                    break;
                                case ComputerType.Laptop:
                                    l++;
                                    break;
                                case ComputerType.Server:
                                    s++;
                                    break;
                            }
                        }
                

            Console.WriteLine("Desktop-{0}\n Laptop-{1}\n Server-{2}\n all-{3}\n", d, l, s, a);



            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            int max_HDD = 0, max_CPU = 0, max_Memory = 0;
            for (int j = 0; j < jagged_array.Length; j++)
                for (int i = 0; i < jagged_array[j].Length; i++)
                {
                    if (jagged_array[j][i].HDD > max_HDD)
                        max_HDD = jagged_array[j][i].HDD;

                    if (jagged_array[j][i].CPU > max_CPU)
                        max_CPU = jagged_array[j][i].CPU;

                    if (jagged_array[j][i].Memory > max_Memory)
                        max_Memory = jagged_array[j][i].Memory;

                }
            Console.WriteLine(" max HDD = {0}\n max_CPU = {1}\n max_Memory = {2}", max_HDD, max_CPU, max_Memory);
            Console.WriteLine("HDD index");
            for (int j = 0; j < jagged_array.Length; j++)
                for (int i = 0; i < jagged_array[j].Length; i++)
                {
                    if (jagged_array[j][i].HDD == max_HDD)
                    {
                        Console.WriteLine("{0}.{1}", j, i);
                    }
                }
            Console.WriteLine("CPU index");
            for (int j = 0; j < jagged_array.Length; j++)
                for (int i = 0; i < jagged_array[j].Length; i++)
                {
                    if (jagged_array[j][i].CPU == max_CPU)
                    {
                        Console.WriteLine("{0}.{1}", j, i);
                    }
                }
            Console.WriteLine("Memory index");
            for (int j = 0; j < jagged_array.Length; j++)
                for (int i = 0; i < jagged_array[j].Length; i++)
                {
                    if (jagged_array[j][i].Memory == max_Memory)
                    {
                        Console.WriteLine("{0}.{1}", j, i);
                    }
                }
            for (int j = 0; j < jagged_array.Length; j++)
                for (int i = 0; i < jagged_array[j].Length; i++)
                {
                    if (jagged_array[j][i].Type == ComputerType.Desktop)
                        jagged_array[j][i].CPU = 8;
                }

                    Console.ReadKey();


            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions


            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements

        }
 
    }
}
