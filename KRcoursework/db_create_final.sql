CREATE TABLE Students (
N_zalik  VARCHAR (10) NOT NULL PRIMARY KEY,
FirstName VARCHAR(20) NOT NULL ,
LastName VARCHAR (30) NOT NULL,
StGroup VARCHAR (10) NOT NULL,
MathMod_m NUMBER (10),
DB_m NUMBER (10),
History_m NUMBER (10),
Philosophy_m NUMBER (10),
HighMath_m NUMBER (10),
Engl_m NUMBER (10),
Eсon_m NUMBER (10)
);

CREATE TABLE Teachers (
N_trud  VARCHAR (10) NOT NULL PRIMARY KEY,
FirstName VARCHAR(20) NOT NULL,
LastName VARCHAR (30) NOT NULL,
Рatronymic VARCHAR (30) NOT NULL,
Subject VARCHAR (50),
Password VARCHAR (20),
email VARCHAR (50)
);

CREATE TABLE Deanery (
empl_id  NUMBER (10) PRIMARY KEY,
FirstName VARCHAR(20) NOT NULL,
LastName VARCHAR (30) NOT NULL,
Password VARCHAR (20),
email VARCHAR (40)
);

CREATE TABLE Timesheet (
ts_id  NUMBER (10),
ts_date DATE NOT NULL,
N_zalik VARCHAR (10) NOT NULL,
N_trud  VARCHAR (10) NOT NULL,
empl_id  NUMBER (10),
PRIMARY KEY (ts_id),
CONSTRAINT fk_StudTs FOREIGN KEY (N_zalik)
REFERENCES Students(N_zalik),
CONSTRAINT fk_TechTs FOREIGN KEY (N_trud)
REFERENCES Teachers(N_trud),
CONSTRAINT fk_DeanTs FOREIGN KEY (empl_id)
REFERENCES Deanery(empl_id)
);

CREATE SEQUENCE ts_id START WITH 1;
CREATE OR REPLACE TRIGGER ts_id 
BEFORE INSERT ON Timesheet 
FOR EACH ROW
BEGIN
  SELECT ts_id.NEXTVAL
  INTO   :new.ts_id
  FROM   dual;
END;
/

CREATE SEQUENCE empl_id START WITH 1;
CREATE OR REPLACE TRIGGER empl_id 
BEFORE INSERT ON Deanery 
FOR EACH ROW
BEGIN
  SELECT empl_id.NEXTVAL
  INTO   :new.empl_id
  FROM   dual;
END;
/