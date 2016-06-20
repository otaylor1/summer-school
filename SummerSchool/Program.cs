﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        static string[] students = new string[15];


        static int NextAvailibleSpace()
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                    return i;
                }

            }
            return -1;
        }

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

                string responseAsText = Console.ReadLine();
                int response;
                response = Convert.ToInt32(responseAsText);


                if (response == 1)
                {
                    {

                        EnrollStudent();

                    }
                }


                else if (response == 2)
                {

                    UnenrollStudent();

                }


                else if (response == 3)
                {

                    PrintStudents();

                }


                else if (response == 4)
                {

                    Exit();
                    break;

                }


                else
                {

                    Console.WriteLine("Please enter a number 1-4");

                }
            }
        }
        static void EnrollStudent()
        {


            Console.WriteLine("Enroll Student");
            Console.Write("Please enter students name: ");
            string name = Console.ReadLine();

            //put student in next available spot in name
            int spot = NextAvailibleSpace();
            students[spot] = name;

            Console.WriteLine(name + " is now enrolled");
            Console.WriteLine(name + " needs to pay ___");
            Console.ReadKey();
            Console.Clear();


        }
        static void UnenrollStudent()
        {


            Console.WriteLine("Unenroll Student");

            for (int i = 0; i < students.Length; i++)
            {

                Console.WriteLine("{0}  {1}" , i + 1,  students[i]);

            }

            Console.Write("Please enter students number: ");
            string answer = Console.ReadLine();
            int number = Convert.ToInt32(answer);
            Console.WriteLine(students[number - 1] + " is now unenrolled");
            students[number - 1] = null;

            

            

            Console.ReadKey();
            Console.Clear();



        }

        static void PrintStudents()
        {

            for (int i = 0; i < students.Length; i++)
            {
               
                Console.WriteLine(students[i]);

            }

        }
        static void Exit()
        {

            Console.WriteLine("Goodbye");
            Console.ReadKey();


        }

    }
}
