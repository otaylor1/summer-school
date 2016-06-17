using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        static string[] Students = new string[15];


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Enroll a student");
                Console.WriteLine("2. Unenroll a student");
                Console.WriteLine("3. Print list of enrolled students");
                Console.WriteLine("4. Exit");
                Console.ReadKey();
                Console.Clear();



                string responseAsText = Console.ReadLine();
                int response;
                response = Convert.ToInt32(responseAsText);


                if (response == 1)
                //while (response == 1)
                {
                    //EnrollStudent();
                    Console.WriteLine("Enroll Student");
                    Console.WriteLine("Please enter students name:");
                    string name = Console.ReadLine();
                    Console.WriteLine(name + " is now enrolled");
                    Console.WriteLine(name + " needs to pay _____");
                    Console.ReadKey();
                    Console.Clear();
                    


                }


                else if (response == 2)
                {

                    Console.WriteLine("Unenroll Student");
                    Console.WriteLine("Please enter students name:");
                    string name = Console.ReadLine();
                    Console.WriteLine(name + " is now unrolled");
                    Console.ReadKey();
                    Console.Clear();

                }

                else if (response == 3)
                {



                }

                else if (response == 4)

                {
                    Console.WriteLine("Goodbye");
                    Console.ReadKey();
                    break;

                }

            }
        }
    }
}
