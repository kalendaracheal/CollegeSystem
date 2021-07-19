USE CollegeDB;
/* CREATE TABLE Students
(
StudentNumber varchar(10) PRIMARY KEY,
 RegNo varchar(20) NOT NULL,
 FirstName varchar(20) NOT NULL,
 LastName varchar(20) NOT NULL,
 Gender char(1) NOT NULL,
 DateOfBirth DATE,
 CourseName varchar(25),
 YearOfStudy int,
 MobileNumber varchar(15)
 )
 
INSERT INTO Students(StudentNumber, RegNo ,FirstName ,LastName ,Gender ,DateOfBirth,CourseName ,YearOfStudy ,MobileNumber)
VALUES (190071608, '19/U/16508/PS', 'Kalenda', 'Racheal', 'F', '2000-10-08' , 'Computer Science', 2, 0787114757)

INSERT INTO Students(StudentNumber, RegNo ,FirstName ,LastName ,Gender ,DateOfBirth,CourseName ,YearOfStudy ,MobileNumber)
VALUES (190071609, '19/U/16509/PS', 'Marshal', 'Martins', 'M', '1995-11-08' , 'Computer Science', 2, 0788888888)


INSERT INTO Students(StudentNumber, RegNo ,FirstName ,LastName ,Gender ,DateOfBirth,CourseName ,YearOfStudy ,MobileNumber)
VALUES (190071610, '19/U/16510/PS', 'Silver', 'Green', 'M', '1997-01-06' , 'Software Engineering', 3, 0777777777)

INSERT INTO Students (StudentNumber, RegNo ,FirstName ,LastName ,Gender ,DateOfBirth,CourseName ,YearOfStudy ,MobileNumber)
VALUES (190071611, '19/U/16511/PS', 'Arsha', 'Heyes', 'F', '1999-09-03' , 'Information systems', 1, 0781800057)

INSERT INTO Students(StudentNumber, RegNo ,FirstName ,LastName ,Gender ,DateOfBirth,CourseName ,YearOfStudy ,MobileNumber)
VALUES (190071612, '19/U/16512/PS', 'Nina', 'Areo', 'F', '1998-12-04' , 'Software Engineering', 1, 0787111111)

INSERT INTO Students(StudentNumber, RegNo ,FirstName ,LastName ,Gender ,DateOfBirth,CourseName ,YearOfStudy ,MobileNumber)
VALUES (190071613, '19/U/16513/PS', 'Conrad', 'Berk', 'M', '1996-10-18' , 'Information Systems', 3, 0700004757)

CREATE TABLE Courses
(
CourseCode varchar(10) PRIMARY KEY,
CourseName varchar(25),
YearOfStudy int
)


ALTER TABLE courses
DROP COLUMN YearOfStudy;

INSERT INTO Courses(CourseCode, CourseName)
VALUES ('CSC', 'Computer Science');

INSERT INTO Courses(CourseCode, CourseName)
VALUES ('BSSE', 'Software Engineering');


INSERT INTO Courses(CourseCode, CourseName)
VALUES ('IST', 'Information Systems');


CREATE TABLE Department
(
DepartmentID varchar(10),
DepartmentName varchar(50),
LecturerName Varchar(50)
)
ALTER TABLE Department
DROP COLUMN DepartmentID;

ALTER TABLE Department
ADD DepartmentID varchar(10) PRIMARY KEY;


INSERT INTO Department (DepartmentID, DepartmentName, LecturerName)
VALUES ('DEPT-CSC', 'Department Of Computer Science', 'Ntanda Moses');


INSERT INTO Department (DepartmentID, DepartmentName, LecturerName)
VALUES ('DEPT-BSSE', 'Department Of Computer Science', 'Lary Hendrick');


INSERT INTO Department (DepartmentID, DepartmentName, LecturerName)
VALUES ('DEPT-IST', 'Department Of Computer Science', 'Graham Bill');

CREATE TABLE Lecturers
(
LecturerID varchar(10) PRIMARY KEY,
LecturerName varchar(25) NOT NULL,
 Gender char(1) NOT NULL,
 CourseName varchar(25),
 DepartmentName varchar(50),
 MobileNumber varchar(15)
 );
 
 INSERT INTO Lecturers(LecturerID, LecturerName, Gender, CourseName, DepartmentName, MobileNumber)
 VALUES ('L001-CSC', 'Ntanda Moses', 'M', 'Computer Science', 'Department Of Computer Science', 0701020122);
 
 INSERT INTO Lecturers(LecturerID, LecturerName, Gender, CourseName, DepartmentName, MobileNumber)
 VALUES ('L002-BSSE', 'Lary Hendrick', 'M', 'Software Engineering', 'Department Of Software Engineering', 0755551122);

 
 INSERT INTO Lecturers(LecturerID, LecturerName, Gender, CourseName, DepartmentName, MobileNumber)
 VALUES ('L003-IST', 'Graham Bill', 'M', 'Information Systems', 'Department Of Information Systems', 0701001122);
 
 INSERT INTO Lecturers(LecturerID, LecturerName, Gender, CourseName, DepartmentName, MobileNumber)
 VALUES ('L003-IST', 'Aisha Nahi', 'F', 'Information Systems', 'Department Of Information Systems', 07089991022);
 
 CREATE TABLE LectureRooms
 (
 LectureRoomName varchar(20) PRIMARY KEY,
 LectureRoomLevel varchar(20) NOT NULL,
 LectureRoomDescription varchar(100)
 );
 
 INSERT INTO LectureRooms (LectureRoomName, LectureRoomLevel, LectureRoomDescription)
 VALUES ('LLT-1', 'Lecture Room 1', 'Located on the first floor on your immediate left after entering Block B');
 
 
 INSERT INTO LectureRooms (LectureRoomName, LectureRoomLevel, LectureRoomDescription)
 VALUES ('LLT-2', 'Lecture Room 2', 'Located on the first floor on your left near lecture room 1 . Just after entering Block B Level 1');
 
 
 INSERT INTO LectureRooms (LectureRoomName, LectureRoomLevel, LectureRoomDescription)
 VALUES ('LLT-3', 'Lecture Room 3', 'Located on the Second floor on your immediate left after the stairs on Block B');
 
 SELECT * FROM Students;
 
 SELECT * FROM Courses;
 
 SELECT * FROM Lecturers;
 
 SELECT * FROM Department;
 
 SELECT * FROM LectureRooms;
 
 SELECT DISTINCT StudentNumber, RegNo, FirstName,LastName FROM Students;
 
 SELECT * FROM Students Where YearOfStudy =2;
 
 SELECT * FROM Students ORDER BY LastName ;
 
  SELECT * FROM Students ORDER BY FirstName DESC ;
  
  SELECT * FROM Students WHERE Gender='M' AND CourseName = 'Computer Science';
  
  SELECT * FROM Students WHERE Gender='M' OR CourseName = 'Computer Science';
  
  SELECT * FROM Students WHERE NOT LastName ='Racheal';
  
  UPDATE Students 
  SET YearOfStudy = 2 
  WHERE RegNo = '19/16511/PS' ;


SELECT TOP 3 CourseCode
FROM Courses
WHERE  CourseName = 'Computer Science';
  
  
  SELECT MAX(YearOfStudy)
  FROM Students 
  WHERE Gender ='F';
  
  SELECT COUNT(RegNo)
  FROM Students;
  
   SELECT COUNT(LectureRoomName)
  FROM LectureRooms;
  
  SELECT * FROM Courses
  WHERE CourseName LIKE '%e';
  
  SELECT * FROM Lecturers
  WHERE LecturerName LIKE '%a%';
  
  SELECT * FROM Courses
  WHERE CourseName IN ('Computer Science', 'Infomation Systems');
  
  SELECT RegNo 
  FROM Students
  WHERE EXISTS (SELECT CourseName FROM Courses
                WHERE CourseName = 'Software Engineering' );
  
  SELECT UPPER(DepartmentName) 
  AS UppercaseDepartmentName 
  FROM Department;
  
 CREATE PROCEDURE SelectAllStudents 
  AS
  SELECT * FROM Students
  GO;
  */
 
 CREATE PROCEDURE createTableEmployee
 AS
 BEGIN
 SET NOCOUNT ON

 SELECT P.EmployeeID, P.EmployeeName, PD.EmployeeDepartment
 FROM
 Employee P
 INNER JOIN EmployeeDepartment PD ON P.EmployeeID = PD.EmployeeID
 WHERE P.EmployeeID =@PID

 END
 */
