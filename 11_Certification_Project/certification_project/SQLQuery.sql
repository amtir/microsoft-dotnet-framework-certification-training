
CREATE DATABASE LibraryDB;

USE LibraryDB;

-- 1. Branch table
CREATE TABLE Branch (
    BranchId INT IDENTITY PRIMARY KEY,
    BranchName NVARCHAR(100) NOT NULL
);

-- 2. Publication table
CREATE TABLE Publication (
    PublicationId INT IDENTITY PRIMARY KEY,
    PublicationName NVARCHAR(200) NOT NULL
);

-- 3. Student table
CREATE TABLE Student (
    StudentId INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(100),
    BranchId INT FOREIGN KEY REFERENCES Branch(BranchId),
    Gender NVARCHAR(10),
    BirthDate DATE,
    Mobile NVARCHAR(20),
    Address NVARCHAR(200),
    City NVARCHAR(100),
    Pincode NVARCHAR(10),
    PhotoPath NVARCHAR(200),
    Email NVARCHAR(100) UNIQUE,
    Password NVARCHAR(50)
);

-- 4. Admin table (Librarian accounts)
CREATE TABLE AdminUser (
    AdminId INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(100),
    Email NVARCHAR(100) UNIQUE,
    Password NVARCHAR(50)
);


-- 5. Books
CREATE TABLE Book (
    BookId INT IDENTITY PRIMARY KEY,
    BookName NVARCHAR(200),
    Details NVARCHAR(500),
    Author NVARCHAR(200),
    PublicationId INT FOREIGN KEY REFERENCES Publication(PublicationId),
    BranchId INT FOREIGN KEY REFERENCES Branch(BranchId),
    Price DECIMAL(10,2),
    Quantity INT,
    ImagePath NVARCHAR(200)
);

-- 6. IssueBook table (issue + return)
CREATE TABLE IssueBook (
    IssueId INT IDENTITY PRIMARY KEY,
    StudentId INT FOREIGN KEY REFERENCES Student(StudentId),
    BookId INT FOREIGN KEY REFERENCES Book(BookId),
    IssueDate DATE,
    DueDate DATE,
    ReturnDate DATE NULL,
    Penalty DECIMAL(10,2) DEFAULT 0
);


INSERT INTO AdminUser (Name, Email, Password)
VALUES ('Librarian', 'admin@library.com', 'admin123');



USE LibraryDB;

-- If you don't have a branch yet, create one:
INSERT INTO Branch (BranchName) VALUES ('Computer Science');

-- Create a sample student (change values as you like)
INSERT INTO Student
    (Name, BranchId, Gender, BirthDate, Mobile, Address, City, Pincode,
     PhotoPath, Email, Password)
VALUES
    ('Test Student', 1, 'M', '2000-01-01', '1234567890',
     'Test Address', 'Test City', '12345',
     NULL, 'student@library.com', 'stud123');



-- Computer Science (BranchId = 1) 
INSERT INTO Book (BookName, Details, Author, PublicationId, BranchId, Price, Quantity, ImagePath)
VALUES
('Introduction to Algorithms', 'Algorithm design and analysis', 'Thomas H. Cormen', 1, 1, 89.99, 10, NULL),
('Clean Code', 'Writing maintainable code', 'Robert C. Martin', 3, 1, 45.50, 7, NULL),
('Operating System Concepts', 'OS principles and design', 'Abraham Silberschatz', 2, 1, 79.00, 5, NULL);


-- Electrical Engineering (BranchId = 3)
INSERT INTO Book (BookName, Details, Author, PublicationId, BranchId, Price, Quantity, ImagePath)
VALUES
('Electrical Machines', 'Concepts of AC/DC machines', 'P.S. Bimbhra', 4, 3, 55.00, 6, NULL),
('Power Electronics', 'Power devices and systems', 'Muhammad H. Rashid', 2, 3, 65.00, 8, NULL);


-- Mechanical Engineering (BranchId = 2)
INSERT INTO Book (BookName, Details, Author, PublicationId, BranchId, Price, Quantity, ImagePath)
VALUES
('Strength of Materials', 'Material strength concepts', 'R.K. Bansal', 1, 2, 40.00, 12, NULL),
('Thermodynamics', 'Engineering thermodynamics', 'Yunus A. Cengel', 5, 2, 75.00, 4, NULL);


-- Add more Students 
INSERT INTO Student (Name, BranchId, Gender, BirthDate, Mobile, Address, City, Pincode, PhotoPath, Email, Password)
VALUES
('Alice Johnson', 1, 'F', '2001-02-14', '9876543210', '123 Main St', 'New York', '10001', NULL, 'alice@library.com', 'alice123'),
('Ravi Kumar', 2, 'M', '2000-05-22', '9123456780', '22 Hill Road', 'Mumbai', '400050', NULL, 'ravi@library.com', 'ravi123'),
('Sarah Lee', 3, 'F', '2002-03-10', '9988776655', '45 Elm Street', 'Toronto', 'M4B1B3', NULL, 'sarah@library.com', 'sarah123');






