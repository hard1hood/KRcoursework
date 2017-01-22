CREATE TABLE Students (
N_zalik  NVARCHAR2 (10) NOT NULL PRIMARY KEY,
FirstName NVARCHAR2(20) NOT NULL ,
LastName NVARCHAR2 (30) NOT NULL,
StGroup NVARCHAR2 (10) NOT NULL
);


CREATE TABLE Users (
N_trud  NVARCHAR2 (10) PRIMARY KEY,
Subject NVARCHAR2 (50),
FirstName NVARCHAR2(20) NOT NULL,
LastName NVARCHAR2 (30) NOT NULL,
Рatronymic NVARCHAR2 (30) NOT NULL,
Email NVARCHAR2 (50),
Login NVARCHAR2 (40) UNIQUE,
Password NVARCHAR2 (20)
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
N_zalik NVARCHAR2 (10) NOT NULL,
N_trud  NVARCHAR2 (10) NOT NULL,
CONSTRAINT fk_StudTs FOREIGN KEY (N_zalik)
REFERENCES Students(N_zalik),
CONSTRAINT fk_UsersTs FOREIGN KEY (N_trud)
REFERENCES Users(N_trud)
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

