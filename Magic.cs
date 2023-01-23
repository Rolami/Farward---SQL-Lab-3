using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farward___Robin_Lab_3.Data;
using Farward___Robin_Lab_3.Models;

namespace Farward___Robin_Lab_3
{
    public class Magic
    {
        //EF

        public static void PrintStudent()
        {
            using (var context = new FarwardDbContext())
            {
                Console.WriteLine("These are the current available classes: ");
                PrintCourses();
                //Console.WriteLine("All");
                Console.WriteLine("Input the class you want to see student from: ");
                Console.WriteLine("(All is an alternative)");
                string CourseChoice = Console.ReadLine().ToUpper();
                var CName = context.Courses;

                var student = (from ST in context.Students
                               join G in context.Grades on ST.StudentId equals G.FkStudentId
                               join C in context.Courses on G.FkCourseId equals C.CourseId
                               where C.CourseName == CourseChoice
                               select new
                               {
                                   FirstName = ST.FirstName,
                                   LastName = ST.LastName,
                                   CourseName = C.CourseName
                               }).Distinct();


                Console.WriteLine("Sort by:");
                Console.WriteLine("1. First name");
                Console.WriteLine("2. Last name");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine().ToUpper());

                Console.WriteLine("Sort order:");
                Console.WriteLine("1. Ascending");
                Console.WriteLine("2. Descending");

                Console.Write("Enter your choice: ");
                int order = int.Parse(Console.ReadLine().ToUpper());



                switch (choice)
                {
                    case 1:
                        // sort by first name
                        switch (order)
                        {
                            case 1:
                                student = student.OrderBy(s => s.FirstName);
                                break;
                            case 2:
                                student = student.OrderByDescending(s => s.FirstName);
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Using default sorting order.");
                                break;
                        }
                        break;

                    case 2:
                        // sort by last name
                        switch (order)
                        {
                            case 1:
                                student = student.OrderBy(s => s.LastName);
                                break;
                            case 2:
                                student = student.OrderByDescending(s => s.LastName);
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Using default sorting field.");
                                break;
                        }
                        break;
                }
                Console.WriteLine("-----------------------------------");
                foreach (var item in student)
                {
                    Console.Write($"{item.FirstName}, {item.LastName}\n");


                }

                while (true)
                {
                    if (string.IsNullOrEmpty(CourseChoice))
                    {
                        Console.WriteLine("Input cannot be empty.");
                    }
                    else
                    {
                        break;
                    }
                }

                if (CourseChoice == "ALL")
                {
                    var allstud = from S in context.Students
                                  select new
                                  {
                                      //S = Student Table
                                      FirstName = S.FirstName,
                                      LastName = S.LastName,
                                  };
                    foreach (var item in allstud)
                    {
                        Console.Write($"{item.FirstName}, {item.LastName}\n");

                    }


                }


            }
        }
        public static void PrintTeacher()
        {
            Console.WriteLine("This is a list of all the teachers.");
            using (var context = new FarwardDbContext())
            {
                var teacher = from Teach in context.Employees
                              where Teach.IsTeacher == "Yes"
                              select new
                              {

                                  FirstName = Teach.FirstName,
                                  LastName = Teach.LastName
                              };

                foreach (var item in teacher)
                {
                    Console.Write($"{item.FirstName}, {item.LastName}\n");


                }


            }



        }

        public static void PrintEmployee()
        {
            Console.WriteLine("This is a list of all the employees no matter the role\n");
            using (var context = new FarwardDbContext())
            {
                var teacher = from Emp in context.Employees

                              select new
                              {

                                  FirstName = Emp.FirstName,
                                  LastName = Emp.LastName,
                                  EmployeeRole = Emp.EmployeeRole

                              };

                foreach (var item in teacher)
                {
                    Console.Write($"{item.FirstName.PadRight(10)} {item.LastName.PadRight(10)}:  {item.EmployeeRole}\n");


                }

            }

        }

        public static void EmployeeCount()
        {
            using (var context = new FarwardDbContext())
            {
                var Employ = from Emp in context.Employees
                              group Emp by Emp.EmployeeRole into ER //EmployeeRole
                              select new
                              {
                                  Role = ER.Key,
                                  Count = ER.Count()
                              };

                foreach (var item in Employ)
                {
                    Console.Write($"{item.Role}: {item.Count} employees\n");
                }
            }





        }


        public static void PrintCourses()
        {
            using (var context = new FarwardDbContext())
            {
                var PC = from C in context.Courses

                         select new
                         {
                             CourseName = C.CourseName
                         };

                foreach (var item in PC)
                {
                    Console.Write($"{item.CourseName}\n");


                }



            }
        }

        public static void AddStudent()
        {
            using (var context = new FarwardDbContext())
            {
                Console.WriteLine("Enter Personnal number (12 numbers): ");
                string SSN = Console.ReadLine();
                Console.Write("Enter the first name: ");
                string FName = Console.ReadLine();

                Console.Write("Enter the last name: ");
                string LName = Console.ReadLine();

                var studadd = new Student
                {
                    FirstName = FName,
                    LastName = LName,
                    Ssn = SSN
                };
                context.Students.Add(studadd);
                context.SaveChanges();

                Console.WriteLine($"{studadd.FirstName}, {studadd.LastName} with ssn: {studadd.Ssn} has been added.");
            }



        }
        public static void AddTeacher()
        {
            using (var context = new FarwardDbContext())
            {
                Console.Write("Enter the first name: ");
                string FName = Console.ReadLine();

                Console.Write("Enter the last name: ");
                string LName = Console.ReadLine();

                var teachadd = new Employee
                {
                    FirstName = FName,
                    LastName = LName,
                    IsTeacher = "Yes",
                    EmployeeRole = "Teacher"
                };
                context.Employees.Add(teachadd);
                context.SaveChanges();

                Console.WriteLine($"{teachadd.FirstName}, {teachadd.LastName} has been added.");
            }





        }

        public static void ActiveCourses()
        {
            using (var context = new FarwardDbContext())
            {
                Console.WriteLine("These are the current Courses: ");


                var AC = from C in context.Courses


                         where C.IsActive == "Yes"
                         select new
                         {
                             CourseID = C.CourseId,
                             CourseName = C.CourseName,


                         };

                foreach (var item in AC)
                {
                    Console.Write($"{item.CourseName}\n");


                }



            }

        }
    }
}
