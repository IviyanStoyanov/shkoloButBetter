﻿USE [shkoloButBetter];

-- Create table
CREATE TABLE [students] 
(
	[id] INT, 
	[name] VARCHAR(50), 
	[email] VARCHAR(50),
	[grade] INT,
	[birthDate] Date
);

CREATE TABLE [marks] 
(
	[id] INT, 
	[stud] INT,
	[mark] Decimal, 
	[subject] VARCHAR(50),
	[teacher] VARCHAR(50),
	[date] Date
	CONSTRAINT [fk_students_id_marks] FOREIGN KEY([stud]) REFERENCES [students]([Id]),
);
