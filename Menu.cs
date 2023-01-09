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
            Console.WriteLine("Welcome to the Farward database.");
            while (true)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Menu:\n1. Employees\n2. Teachers\n3. Students\n4. Add new student \n5. Add Teacher\n6. Main Menu\n7. Quit");
                //FIX MENU NUMBERS

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
                            Console.WriteLine("Thank you.");
                            break;
                        }

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;

                }
                if (choice == 7)
                {
                    Console.WriteLine("Exiting program");
                    break;
                }

            }
        }


    }
}
