INSERT INTO Students (N_zalik,FirstName,LastName,StGroup,MathMod_m,DB_m,History_m,Philosophy_m,HighMath_m, Engl_m, Eсon_m) 
VALUES ('КМ1234','Іван','Іванов','КМ-12',NULL,NULL,NULL,NULL,NULL,NULL,NULL);

INSERT INTO Students (N_zalik,FirstName,LastName,StGroup,MathMod_m,DB_m,History_m,Philosophy_m,HighMath_m, Engl_m, Eсon_m) 
VALUES ('КМ1235','Дмитро','Петров','КМ-12',NULL,NULL,NULL,NULL,NULL,NULL,NULL);

INSERT INTO Students (N_zalik,FirstName,LastName,StGroup,MathMod_m,DB_m,History_m,Philosophy_m,HighMath_m, Engl_m, Eсon_m) 
VALUES ('КМ1236','Марія','Симонова','КМ-12',NULL,NULL,NULL,NULL,NULL,NULL,NULL);

INSERT INTO Students (N_zalik,FirstName,LastName,StGroup,MathMod_m,DB_m,History_m,Philosophy_m,HighMath_m, Engl_m, Eсon_m) 
VALUES ('КМ1336','Марина','Охрименко','КМ-13',NULL,NULL,NULL,NULL,NULL,NULL,NULL);

INSERT INTO Students (N_zalik,FirstName,LastName,StGroup,MathMod_m,DB_m,History_m,Philosophy_m,HighMath_m, Engl_m, Eсon_m) 
VALUES ('КМ1135','Анна','Коваленко','КМ-11',NULL,NULL,NULL,NULL,NULL,NULL,NULL);

INSERT INTO Students (N_zalik,FirstName,LastName,StGroup,MathMod_m,DB_m,History_m,Philosophy_m,HighMath_m, Engl_m, Eсon_m) 
VALUES ('КМ1135','Богдан','Кольченко','КМ-11',NULL,NULL,NULL,NULL,NULL,NULL,NULL);


INSERT INTO Teachers (N_trud,FirstName,LastName,Рatronymic,Subject,Password,email) 
VALUES ('AT12345','Тетяна','Ладогубець','Сергіївна','Мат.моделювання','lad1','lad@gmail.com');

INSERT INTO Teachers (N_trud,FirstName,LastName,Рatronymic,Subject,Password,email) 
VALUES ('AT12346','Ігор','Терещенко','Олександрович','БД та ІС','ter2','Ter@gmail.com');

INSERT INTO Teachers (N_trud,FirstName,LastName,Рatronymic,Subject,Password,email) 
VALUES ('AT12347','Олег','Чертов','Романович','Мат.ан','chertov3','chertov@gmail.com');


INSERT INTO Deanery (empl_id,FirstName,LastName, PASSWORD,email) 
VALUES ('1','Вікторія','Перга','perga','perga@gmail.com');

INSERT INTO Deanery (empl_id,FirstName,LastName,PASSWORD,email) 
VALUES ('2','Лариса','Бойко','boyko','boyko@gmail.com');


INSERT INTO Deanery (empl_id,FirstName,LastName, PASSWORD,email) 
VALUES ('1','Вікторія','Перга','perga','perga@gmail.com');

INSERT INTO Deanery (empl_id,FirstName,LastName,PASSWORD,email) 
VALUES ('2','Лариса','Бойко','boyko','boyko@gmail.com');

INSERT INTO Deanery (empl_id,FirstName,LastName, PASSWORD,email) 
VALUES ('','Тетяна','Новосад','novos','novos@gmail.com');


INSERT INTO Timesheet (ts_id,ts_date,N_zalik,N_trud,empl_id) 
VALUES ('1','21.01.2017','КМ1234','AT12346','1');







