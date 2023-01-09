using Farward___Robin_Lab_3.Data;

namespace Farward___Robin_Lab_3
{
    internal class Program
    {
        /*
         Robin Larsson
         Net22 - Lab 3 SQL
                  
         */
        
        
        //SQL
        /*  Uppgift 1, SQL alla anställda
            select EmployeeID, FirstName, LastName, EmployeeRole
            from Employee
            --where IsTeacher = 'Yes' 

        ---------------------------------------------------------------------------------------
            Uppgift : Hämta alla betyg som satts den senaste månaden 
        ---------------------------------------------------------------------------------------
            SELECT *
            from Grade
            where GradeSet Between DATEADD(m, -1, GetDate()) and GETDATE() 
        ---------------------------------------------------------------------------------------
            Uppgift : Hämta en lista med alla kurser och 
                det snittbetyg som eleverna fått på den kursen samt 
                det högsta och lägsta betyget som någon fått i kursen 
                
                Här får användaren direkt upp en lista med alla kurser i databasen, 
                snittbetyget samt det högsta och lägsta betyget för varje kurs.
        ---------------------------------------------------------------------------------------
        select CourseName, Min(Grade) as Lowest, Max(Grade) as Higest, AVG(Grade) as AverageGrade, COUNT(StudentID) as NumberOfStudents
        from Grade
        join Course on CourseID=FK_CourseID
        join Student on StudentID=FK_StudentID
        group by CourseName

        ---------------------------------------------------------------------------------------
            Uppgift : Lägga till nya elever 
        ---------------------------------------------------------------------------------------
        insert into Student (SSN,FirstName,LastName)
        values ('xxxxxxxx-xxxx', 'Namn', 'Namsson');
        ---------------------------------------------------------------------------------------
         
         
         */



        static void Main(string[] args)
        {
            Menu.Navigation();

 
            }

    }
    }
