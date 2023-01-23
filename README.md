# Farward - Robin Lab 4
H�r �r SQL Querys f�r alla olika l�sningar

        //SQL
        /*  H�mta alla anst�llda, SQL
            select EmployeeID, FirstName, LastName, EmployeeRole
            from Employee
            --where IsTeacher = 'Yes' 

        ---------------------------------------------------------------------------------------
            H�mta alla betyg som satts den senaste m�naden 
        ---------------------------------------------------------------------------------------
            SELECT *
            from Grade
            where GradeSet Between DATEADD(m, -1, GetDate()) and GETDATE() 
        ---------------------------------------------------------------------------------------
        Uppgift : H�mta en lista med alla kurser och 
        ---------------------------------------------------------------------------------------
                det snittbetyg som eleverna f�tt p� den kursen samt 
                det h�gsta och l�gsta betyget som n�gon f�tt i kursen 
                
                H�r f�r anv�ndaren direkt upp en lista med alla kurser i databasen, 
                snittbetyget samt det h�gsta och l�gsta betyget f�r varje kurs.
        ---------------------------------------------------------------------------------------
            select CourseName, Min(Grade) as Lowest, Max(Grade) as Higest, AVG(Grade) as AverageGrade, COUNT(StudentID) as NumberOfStudents
            from Grade
            join Course on CourseID=FK_CourseID
            join Student on StudentID=FK_StudentID
            group by CourseName

        ---------------------------------------------------------------------------------------
        Uppgift : L�gga till nya elever 
        ---------------------------------------------------------------------------------------
        insert into Student (SSN,FirstName,LastName)
        values ('xxxxxxxx-xxxx', 'Namn', 'Namsson');
        ---------------------------------------------------------------------------------------
        Uppgift: Visa medell�n per avdelning (Per arbetsroll)
        ---------------------------------------------------------------------------------------
            select EmployeeRole as Department, AVG(Salary) as Salary 
            from Employee
            group by EmployeeRole
            ORDER BY Salary Desc
        ---------------------------------------------------------------------------------------
        Uppgift: Visa hur mycket de olika avdelningarna betalar ut i l�n varje m�nad
        ---------------------------------------------------------------------------------------
            select EmployeeRole as Department, Sum(Salary)/12 as Salary 
            from Employee
            group by EmployeeRole
            ORDER BY Salary Desc
        ---------------------------------------------------------------------------------------
        Uppgift: Procedure f�r att h�mta viktig info om en student
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
        Uppgift: Skolan vill kunna ta fram en �versikt �ver all personal d�r det framg�r namn 
        och vilka befattningar de har samt hur m�nga �r de har arbetat p� skolan. 
        Administrat�ren vill ocks� ha m�jlighet att spara ner ny personal. (SQL i SSMS)
        ---------------------------------------------------------------------------------------
        
        
        SELECT EmployeeRole, FirstName, LastName,
        DATEDIFF(year, HireDate, GETDATE()) as YearsWithCompany
        FROM Employee
        Order By YearsWithCompany Desc

        ---------------------------------------------------------------------------------------
        L�gga till ny personal
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
        Vi vill spara ner elever och se vilken klass de g�r i. 
        ---------------------------------------------------------------------------------------
        select Concat(FirstName, ' ', LastName) as Student, Class
        from Student
        
        
        ---------------------------------------------------------------------------------------
        Vi vill kunna spara ner betyg f�r en elev i varje kurs de l�st 
        och vi vill kunna se vilken l�rare som satt betyget. Betyg ska ocks� ha ett datum d� de satts. (SQL i SSMS)
        ---------------------------------------------------------------------------------------
              select CONCAT(Student.FirstName,' ', Student.LastName) as Student ,CourseName, Grade, GradeSet, CONCAT(Employee.FirstName,' ', Employee.LastName) as Teacher
            from Grade
            join Course on CourseID=FK_CourseID
            join Student on StudentID=FK_StudentID
			join Employee on EmployeeID=FK_TeacherId
			order by GradeSet DESC
        ---------------------------------------------------------------------------------------



         */