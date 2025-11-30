SELECT TOP (1000) [name]
      ,[occupation]
      ,[working_date]
      ,[working_hours]
      ,[salary]
  FROM [Employees].[dbo].[employee]


  create table user101(id int IDENTITY(1,1) PRIMARY KEY,
  Name varchar(255) NOT NULL,
  City varchar(255),
  email varchar(255)
  );


