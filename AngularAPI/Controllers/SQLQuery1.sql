DROP TABLE Person

CREATE TABLE [dbo].[Person] (
    [FirstName] NVARCHAR (50) NOT NULL,
    [LastName]  NVARCHAR (50) NOT NULL,
    [Enlisted]  BIT           NOT NULL,
    [ID]        INT           NOT NULL,
    [DoB]       DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


INSERT INTO Person (FirstName, LastName, Enlisted, ID, DoB)
VALUES	('Mihir', 'Patel', 1, 123, '1991-09-08'),
		('Frank', 'Gore',	1, 456,	'1992-01-12'),
		('Gabe', 'Adams', 1, 789, '1990-12-08')

		select * From Person; 
		
UPDATE Person SET FirstName = 'Arjun' WHERE ID = 789		
