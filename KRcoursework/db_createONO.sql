CREATE TABLE Students (
N_zalik  VarChar (10) NOT NULL PRIMARY KEY,
FirstName VarChar(20) NOT NULL ,
LastName VarChar (30) NOT NULL,
StGroup VarChar (10) NOT NULL
);


CREATE TABLE Users (
N_trud  VarChar (10) PRIMARY KEY,
Subject VarChar (50),
FirstName VarChar(20) NOT NULL,
LastName VarChar (30) NOT NULL,
Patronymic VarChar (30) NOT NULL,
Email VarChar (50),
Login VarChar (40) UNIQUE,
Password VarChar (20)
);

CREATE TABLE Timesheet (
ts_id  NUMBER (10) NOT NULL PRIMARY KEY,
DB NUMBER (10),
HighMath NUMBER (10),
History NUMBER (10),
Philosophy NUMBER (10),
MathModeling NUMBER (10),
English NUMBER (10),
AppliedSoftware NUMBER (10),
Economy NUMBER (10),
WebTech NUMBER (10),
Phisics NUMBER (10),
PhisCulture NUMBER (10),
AnlineAnalis NUMBER (10),
MethodsMathPhys NUMBER (10),
Ukrainian NUMBER (10),
Programming NUMBER (10),
N_zalik VarChar (10) NOT NULL,
CONSTRAINT fk_StudTs FOREIGN KEY (N_zalik)
REFERENCES Students(N_zalik),
);

CREATE SEQUENCE tsh_id START WITH 1;
CREATE OR REPLACE TRIGGER trig_id 
BEFORE INSERT ON Timesheet 
FOR EACH ROW
BEGIN
  SELECT ts_id.NEXTVAL
  INTO   :new.ts_id
  FROM   dual;
END;
/

CREATE VIEW ShowStudMarks AS
 SELECT FirstName, LastName,StGroup, Timesheet.N_zalik, DB,HighMath,History,
	 Philosophy,MathModeling, English,AppliedSoftware,
	 Economy,WebTech,Phisics,PhisCulture,AnlineAnalis,
	 MethodsMathPhys,Ukrainian,Programming
 FROM Timesheet LEFT JOIN Students ON Timesheet.N_zalik=Students.N_zalik; 
