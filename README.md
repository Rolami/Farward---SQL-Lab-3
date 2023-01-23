# Farward - Robin Lab 4
Här är SQL Querys för alla olika lösningar

        //SQL
        /*  Hämta alla anställda, SQL
            select EmployeeID, FirstName, LastName, EmployeeRole
            from Employee
            --where IsTeacher = 'Yes' 

        ---------------------------------------------------------------------------------------
            Hämta alla betyg som satts den senaste månaden 
        ---------------------------------------------------------------------------------------
            SELECT *
            from Grade
            where GradeSet Between DATEADD(m, -1, GetDate()) and GETDATE() 
        ---------------------------------------------------------------------------------------
        Uppgift : Hämta en lista med alla kurser och 
        ---------------------------------------------------------------------------------------
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
        Uppgift: Visa medellön per avdelning (Per arbetsroll)
        ---------------------------------------------------------------------------------------
            select EmployeeRole as Department, AVG(Salary) as Salary 
            from Employee
            group by EmployeeRole
            ORDER BY Salary Desc
        ---------------------------------------------------------------------------------------
        Uppgift: Visa hur mycket de olika avdelningarna betalar ut i lön varje månad
        ---------------------------------------------------------------------------------------
            select EmployeeRole as Department, Sum(Salary)/12 as Salary 
            from Employee
            group by EmployeeRole
            ORDER BY Salary Desc
        ---------------------------------------------------------------------------------------
        Uppgift: Procedure för att hämta viktig info om en student
        ---------------------------------------------------------------------------------------
        Create Procedure StudInf (@StudentID INT)
        as 
        Begin
            SELECT *
	        From Student
            WHERE StudentID = @StudentID
        End

        Exec StudInf @StudentId=3
        ---------------------------------------------------------------------------------------
        Uppgift: Skolan vill kunna ta fram en översikt över all personal där det framgår namn 
        och vilka befattningar de har samt hur många år de har arbetat på skolan. 
        Administratören vill också ha möjlighet att spara ner ny personal. (SQL i SSMS)
        ---------------------------------------------------------------------------------------
        
        
        SELECT EmployeeRole, FirstName, LastName,
        DATEDIFF(year, HireDate, GETDATE()) as YearsWithCompany
        FROM Employee
        Order By YearsWithCompany Desc

        ---------------------------------------------------------------------------------------
        Lägga till ny personal
        ---------------------------------------------------------------------------------------
        insert into Employee (EmployeeRole,IsTeacher,FirstName,LastName,Salary,HireDate)
        values ('Jobbtitel', 'Yes/No', 'Namn', 'Namsson','xxxxxxx', 'xxxxx-xx-xx');
        ---------------------------------------------------------------------------------------

        ---------------------------------------------------------------------------------------

        Begin transaction GradeOne
        Begin Try
        
            Update Grade
            Set Grade = 5, GradeSet = GetDate()
            where GradeId = 6
                           
        Commit Transaction GradeOne
	   
        End Try
               
        Begin Catch
	        Rollback Transaction GradeOne
        
        End Catch
        
        Select * from Grade

        ---------------------------------------------------------------------------------------
        Vi vill spara ner elever och se vilken klass de går i. 
        ---------------------------------------------------------------------------------------
        select Concat(FirstName, ' ', LastName) as Student, Class
        from Student
        
        
        ---------------------------------------------------------------------------------------
        Vi vill kunna spara ner betyg för en elev i varje kurs de läst 
        och vi vill kunna se vilken lärare som satt betyget. Betyg ska också ha ett datum då de satts. (SQL i SSMS)
        ---------------------------------------------------------------------------------------
              select CONCAT(Student.FirstName,' ', Student.LastName) as Student ,CourseName, Grade, GradeSet, CONCAT(Employee.FirstName,' ', Employee.LastName) as Teacher
            from Grade
            join Course on CourseID=FK_CourseID
            join Student on StudentID=FK_StudentID
			join Employee on EmployeeID=FK_TeacherId
			order by GradeSet DESC
        ---------------------------------------------------------------------------------------



         */