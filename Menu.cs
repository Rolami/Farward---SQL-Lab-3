using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farward___Robin_Lab_3
{

    internal class Menu
    {
        public static void Navigation()
        {
            string line = "------------------------------------------\n";
            string Welcome = "\r\n   ▄████████    ▄████████    ▄████████  ▄█     █▄     ▄████████    ▄████████ ████████▄  \r\n  ███    ███   ███    ███   ███    ███ ███     ███   ███    ███   ███    ███ ███   ▀███ \r\n  ███    █▀    ███    ███   ███    ███ ███     ███   ███    ███   ███    ███ ███    ███ \r\n ▄███▄▄▄       ███    ███  ▄███▄▄▄▄██▀ ███     ███   ███    ███  ▄███▄▄▄▄██▀ ███    ███ \r\n▀▀███▀▀▀     ▀███████████ ▀▀███▀▀▀▀▀   ███     ███ ▀███████████ ▀▀███▀▀▀▀▀   ███    ███ \r\n  ███          ███    ███ ▀███████████ ███     ███   ███    ███ ▀███████████ ███    ███ \r\n  ███          ███    ███   ███    ███ ███ ▄█▄ ███   ███    ███   ███    ███ ███   ▄███ \r\n  ███          ███    █▀    ███    ███  ▀███▀███▀    ███    █▀    ███    ███ ████████▀  \r\n                            ███    ███                            ███    ███            \r\n";
            Console.WriteLine(Welcome);
            Console.WriteLine("Welcome to the Farward database.");
            while (true)
            {
                Console.WriteLine(line);
                Console.WriteLine("Menu:\n1. Employees\n" +
                    "2. Teachers\n" +
                    "3. Students\n" +
                    "4. Add new student \n" +
                    "5. Add Teacher\n" +
                    "6. Main Menu\n" +
                    "7. List active courses\n" +
                    "8. Employee count\n" +
                    "9.Quit");


                Console.WriteLine(line);


                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Magic.PrintEmployee();
                            break;
                        }
                    case 2:
                        {
                            Magic.PrintTeacher();
                            break;
                        }
                    case 3:
                        {
                            Magic.PrintStudent();
                            break;
                        }
                    case 4:
                        {
                            Magic.AddStudent();
                            break;
                        }
                    case 5:
                        {
                            Magic.AddTeacher();
                            break;
                        }
                    case 6:
                        {
                            Navigation();
                            break;
                        }
                    case 7:
                        {
                            Magic.ActiveCourses();
                            break;
                        }
                    case 8:
                        {
                            Magic.EmployeeCount();
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Thank you.");
                            break;
                        }

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;

                }
                if (choice == 9)
                {
                    Console.WriteLine("Exiting program");
                    break;
                }

            }
        }


    }
}
