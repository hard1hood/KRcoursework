INSERT INTO Students (N_zalik,FirstName,LastName,StGroup) 
VALUES ('KM1234','Ivan','Ivanov','KM-12');

INSERT INTO Students (N_zalik,FirstName,LastName,StGroup) 
VALUES ('KM1135','Anna','Kovalenko','KM-11');

INSERT INTO Students (N_zalik,FirstName,LastName,StGroup) 
VALUES ('KM1138','Bohdan','Kolechko','KM-11');



INSERT INTO Users (N_trud, Subject,FirstName,LastName,Patronymic, Email, Login, PASSWORD)  
VALUES ('AT12345','MathModeling','Tetyana','Ladogubets','Sergiivna','lad@gmail.com','lad1','qwe1');

INSERT INTO Users (N_trud, Subject,FirstName,LastName,Patronymic,Email, Login, PASSWORD) 
VALUES ('AT12346','DB','Ihor','Tereshchenko','Oleksandrovych','Ter@gmail.com','ter2','qwe2');

INSERT INTO Users (N_trud, Subject,FirstName,LastName,Patronymic,Email,Login, PASSWORD) 
VALUES ('AT12347','HighMath','Oleg','Chertov','Romanovych','chertov@gmail.com','chertov3','qwe3');

INSERT INTO Users (N_trud, Subject,FirstName,LastName,Patronymic,Email, Login, PASSWORD) 
VALUES ('AT36457','DEANERY','Viktoriya','Perga','Vitaliivna','perga@gmail.com','perga','qwe4');

INSERT INTO Users (N_trud, Subject,FirstName,LastName,Patronymic,Email, Login, PASSWORD) 
VALUES ('AT58463','DEANERY','Larysa','Boyko','Viktorivna','boyko@gmail.com','boyko','qwe5');

INSERT INTO Users (N_trud, Subject,FirstName,LastName,Patronymic,Email, Login, PASSWORD) 
VALUES ('AT37592','DEANERY','Tetyana','Novosad','Ivanivna','novos@gmail.com','novos','qwe6');





INSERT INTO Timesheet (ts_id,DB,HighMath,History,Philosophy,MathModeling, English,
                       AppliedSoftware,Economy,WebTech,Phisics,PhisCulture,
                       AnlineAnalis,MethodsMathPhys,Ukrainian,Programming,N_zalik) 
VALUES ('1','','','','','','','','','','','','','','','','KM1234');

INSERT INTO Timesheet (ts_id,DB,HighMath,History,Philosophy,MathModeling, English,
                       AppliedSoftware,Economy,WebTech,Phisics,PhisCulture,
                       AnlineAnalis,MethodsMathPhys,Ukrainian,Programming,N_zalik) 
VALUES ('1','','','','','','','','','','','','','','','','KM1135');

INSERT INTO Timesheet (ts_id,DB,HighMath,History,Philosophy,MathModeling, English,
                       AppliedSoftware,Economy,WebTech,Phisics,PhisCulture,
                       AnlineAnalis,MethodsMathPhys,Ukrainian,Programming,N_zalik) 
VALUES ('1','','','','','','','','','','','','','','','','KM1138');







