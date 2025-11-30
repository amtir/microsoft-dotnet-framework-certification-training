CREATE TABLE Worker (
    WorkerID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Occupation NVARCHAR(100) NOT NULL,
    PhoneNumber NVARCHAR(20) NOT NULL,
    Location NVARCHAR(100) NOT NULL
);


INSERT INTO Worker (Name, Occupation, PhoneNumber, Location) VALUES
('John Smith', 'Engineer', '1234567890', 'New York'),
('Alice Johnson', 'Doctor', '9876543210', 'Los Angeles'),
('Michael Brown', 'Teacher', '5551122334', 'Chicago'),
('Emma Davis', 'Designer', '4442211333', 'Houston'),
('David Lee', 'Accountant', '6667788990', 'Seattle');



select * from Worker;


CREATE TABLE Employees (
    EmpId     INT IDENTITY(0,1) PRIMARY KEY,
    EmpName   NVARCHAR(100) NOT NULL,
    Contact   NVARCHAR(20)  NULL,
    Email     NVARCHAR(100) NULL,
    Age       INT           NULL,
    City      NVARCHAR(100) NULL,
    State     NVARCHAR(100) NULL,
    Salary    DECIMAL(12,2) NULL
);

INSERT INTO dbo.Employees (EmpName, Contact, Email, Age, City, State, Salary) VALUES
('John Smith','1234567890','john@acme.com', 30,'New York','NY', 85000),
('Alice Johnson','9876543210','alice@contoso.com', 28,'Los Angeles','CA', 92000),
('Michael Brown','5551122334','mike@northwind.com', 35,'Chicago','IL', 78000),
('Emma Davis','4442211333','emma@fabrikam.com', 26,'Houston','TX', 69000),
('David Lee','6667788990','david@tailspin.com', 32,'Seattle','WA', 99000);

select * from employees;