using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        static string[] students = new string[15];

        static Double[] cost = new Double[15];

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

        static int TotalEnrolled()
        {
            int numberOfStudents = 0;

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    numberOfStudents++;
                }

            }

            return numberOfStudents;

        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("Please select an option");
                //number of enrolled
                if (TotalEnrolled() < 15)
                {

                    Console.WriteLine("1. Enroll a student");

                }

                if (TotalEnrolled() > 0)
                {

                    Console.WriteLine("2. Unenroll a student");

                }

                Console.WriteLine("3. Print list of enrolled students");
                Console.WriteLine("4. Exit");

                string responseAsText = Console.ReadLine();
                int response;
                response = Convert.ToInt32(responseAsText);


                if (response == 1)
                {

                    EnrollStudent();

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


            if (TotalEnrolled() < 15)
            {
                Console.WriteLine("Enroll Student");
                Console.Write("Please enter students name: ");
                string name = Console.ReadLine();
               
                //put student in next available spot in name
                int spot = NextAvailibleSpace();
                students[spot] = name;

                //should be double because it is money
                Double fee = 200;

                string tempName = name.ToLower();
              

                if (tempName.Contains("riddle")  )
                {

                    Console.WriteLine("RED ALERT!!! HE WHO MUST NOT BE NAMED!!!");

                }


                if (tempName.Contains("tom") )
                {
                    //longbottom needs to be within tom otherwise it gets a red alert
                    if (tempName.Contains("longbottom"))
                    {

                        if (TotalEnrolled() < 10)
                        {

                            Console.WriteLine("free of charge");
                            fee = 0;

                        }

                        else
                        {

                            Console.WriteLine(fee);

                        }
                    }

                    else
                        Console.WriteLine("RED ALERT!!! HE WHO MUST NOT BE NAMED!!!");

                }

                if (tempName.Contains("voldemort") )
                {

                    Console.WriteLine("RED ALERT!!! HE WHO MUST NOT BE NAMED!!!");

                }

                if (tempName.Contains("malfoy")  )
                {
                    Console.WriteLine("Do Not Enroll");
                    Console.ReadKey();
                    Console.Clear();
                    return;

                }


                if (tempName.Contains("potter")  )
                {
                   
                    fee = fee / 2;

                }

             //allows to look at just first initial of both first and last name
                var firstLastName = name.Split(' ');
                string firstName = firstLastName[0];
                string lastName = firstLastName[1];

                if (firstName.First() == lastName.First())
                {
                    fee = fee * .90;
                }
                

                cost[spot] = fee;

                Console.WriteLine(name + " is now enrolled");
                Console.WriteLine(name + " needs to pay £ {0}", fee);
                Console.ReadKey();

            }

            Console.Clear();

        }

        static void UnenrollStudent()
        {

            Console.WriteLine("Unenroll Student");

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    Console.WriteLine("{0}  {1} ", i + 1, students[i]);
                }

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
            double tempCost = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    Console.WriteLine(students[i] + " (£ " + cost[i] + ")");
                    tempCost = tempCost + cost[i];
                }
                
            }
            
            Console.WriteLine("\nTotal: £ " + tempCost);          
            Console.ReadKey();
            Console.Clear();

        }

        static void Exit()
        {

            Console.WriteLine("Goodbye");
            Console.ReadKey();


        }

    }
}
