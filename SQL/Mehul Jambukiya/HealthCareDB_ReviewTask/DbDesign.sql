/*Draw an ER diagram to capture the requirements as stated below:
In a hospital there are different departments. Patients are treated in these
departments by the doctors assigned to patients. Usually each patient is treated by a
single doctor, but in rare cases they will have two or three. Healthcare assistants will
also attend to patients; every department has many healthcare assistants. Each
patient is required to take a variety of drugs during different parts of the day such as
morning, afternoon and night.*/


CREATE DATABASE HealthCare

USE HealthCare

CREATE TABLE Departments
(
DepartmentId INT CONSTRAINT Departments_DepartmentId_PkAuto PRIMARY KEY IDENTITY(1,1),
DepartmentName VARCHAR(100) CONSTRAINT Departments_DepartmentName_NotNull NOT NULL,
)

ALTER TABLE Departments ADD IsActive BIT DEFAULT 1 NOT NULL

INSERT INTO Departments (DepartmentName)
	VALUES ('General'),('Orthopadic'),('Dental'),('Eye'),('ENT')

CREATE TABLE Doctors
(
DoctorId INT CONSTRAINT Doctors_DoctorId_PkAuto PRIMARY KEY IDENTITY(1,1),
FirstName VARCHAR(30) CONSTRAINT Doctord_FName_NotNull NOT NULL,
LastName VARCHAR(30) CONSTRAINT Doctord_LName_NotNull NOT NULL,
Designation VARCHAR(30) CONSTRAINT Doctord_Designation_NotNull NOT NULL,
YearsOfExperience DECIMAL(3,1) CONSTRAINT Doctors_YearsOfExperience_NotNull NOT NULL,
Department INT CONSTRAINT Doctors_Department_Fk FOREIGN KEY REFERENCES Departments(DepartmentId) ON DELETE SET NULL ON UPDATE CASCADE
)

ALTER TABLE Doctors ADD IsActive BIT DEFAULT 1 NOT NULL

INSERT INTO Doctors VALUES ('Kevin','Shah','MD',4,1),
('Hiren','Bhatt','MBBS',3,1),
('Viral','Sheth','MS',5,4),
('Saurabh','Desai','BDS',3,3),
('Vikas','Patel','MDS',6,3),
('Pinakin','Shah','MS',4,5),
('Saurabh','Gandhi','MS',3,2)

CREATE TABLE Assistants
(
AssistantId INT CONSTRAINT Assistants_DoctorId_PkAuto PRIMARY KEY IDENTITY(1,1),
FirstName VARCHAR(30) CONSTRAINT Assistants_FName_NotNull NOT NULL,
LastName VARCHAR(30) CONSTRAINT Assistants_LName_NotNull NOT NULL,
WorksUnder INT CONSTRAINT Assistants_WorksUnder_Fk FOREIGN KEY REFERENCES Doctors(DoctorId) ON DELETE SET NULL ON UPDATE CASCADE,
YearsOfExperience DECIMAL(3,1) CONSTRAINT Assistants_YearsOfExperience_NotNull NOT NULL,
)

ALTER TABLE Assistants ADD IsActive BIT DEFAULT 1 NOT NULL

INSERT INTO Assistants VALUES ('fname1','lname1',1,2),
('fname2','lname2',2,2),
('fname3','lname3',3,0),
('fname4','lname4',4,1.5),
('fname5','lname5',5,2),
('fname6','lname6',6,1),
('fname7','lname7',7,2),
('fname8','lname8',2,2),
('fname9','lname9',2,1.5)

CREATE TABLE States
(
StateId INT CONSTRAINT States_StateId_Pk PRIMARY KEY IDENTITY(1,1),
StateName VARCHAR(50) CONSTRAINT States_StateName_NotNull NOT NULL
)

INSERT INTO States VALUES ('Gujarat'),('Maharashtra')

CREATE TABLE City
(
CityId INT CONSTRAINT City_CityId_Pk PRIMARY KEY IDENTITY(1,1),
CityName VARCHAR(50) CONSTRAINT City_CityName_NotNull NOT NULL,
StateId INT CONSTRAINT City_StateId_Fk FOREIGN KEY REFERENCES States(StateId)
)

INSERT INTO City VALUES ('Ahmedabad',1),('Baroda',1),('Surat',1),('Pune',2)

CREATE TABLE Patients
(
PatientId INT CONSTRAINT Patient_PatientId_PkAuto PRIMARY KEY IDENTITY(1,1),
FirstName VARCHAR(30) CONSTRAINT Patient_FName_NotNull NOT NULL,
LastName VARCHAR(30) CONSTRAINT Patient_LName_NotNull NOT NULL,
DateOfBirth DATE CONSTRAINT Patient_DateOfBirth_NotNull NOT NULL,
City INT CONSTRAINT Patient_City_Fk NOT NULL FOREIGN KEY REFERENCES City(CityId),
ContactNo NUMERIC(10) CONSTRAINT Patient_ContactNo_Chk CHECK(ContactNo BETWEEN 0000000000 AND 9999999999) UNIQUE
)

ALTER TABLE Patients ADD IsActive BIT DEFAULT 1 NOT NULL

INSERT INTO Patients VALUES ('fname1','lname1','1980-05-04',1,9988776655),
('fname2','lname2','1978-06-03',2,9988776656),
('fname3','lname3','1975-04-02',3,9988776657),
('fname4','lname4','1986-02-04',4,9888776658),
('fname5','lname5','1995-05-06',3,9988776645),
('fname6','lname6','1976-04-16',2,9988776646),
('fname7','lname7','1981-01-18',1,9988776647),
('fname8','lname8','1982-03-04',3,9988776648),
('fname9','lname9','1999-05-14',1,9988776649)

CREATE TABLE Drugs
(
DrugId INT CONSTRAINT Drugs_DrugId_PkAuto PRIMARY KEY IDENTITY(1,1),
DrugName VARCHAR(120) CONSTRAINT Drugs_DrugName_NotNull NOT NULL,
Mg SMALLINT CONSTRAINT Drugs_Mg_NotNull NOT NULL
)

ALTER TABLE Drugs ADD IsActive BIT DEFAULT 1 NOT NULL

INSERT INTO Drugs VALUES ('drug1',500),('drug2',250),('drug3',300),('drug4',100),('drug5',500)

CREATE TABLE DrugTiming
(
TimingId INT CONSTRAINT DrugTiming_TimingId_PkAuto PRIMARY KEY IDENTITY(1,1),
Part VARCHAR(20) CONSTRAINT DrugTiming_Part_NotNull NOT NULL
)

INSERT INTO DrugTiming VALUES ('Morning'),('AfterNoon'),('Night')

CREATE TABLE Treatment
(
TreatmentId INT CONSTRAINT Treatment_TreatmantId_pkAuto PRIMARY KEY IDENTITY(1,1),
Patient INT CONSTRAINT Treatment_Patient_Fk FOREIGN KEY REFERENCES Patients(PatientId) ON DELETE NO ACTION ON UPDATE NO ACTION,
Doctor INT CONSTRAINT Treatment_Doctor_Fk_Def DEFAULT NULL FOREIGN KEY REFERENCES Doctors(DoctorId) ON DELETE NO ACTION ON UPDATE NO ACTION,
Assistant INT CONSTRAINT Treatment_Assistant_Fk_Def DEFAULT NULL FOREIGN KEY REFERENCES Assistants(AssistantId) ON DELETE NO ACTION ON UPDATE NO ACTION,
)

ALTER TABLE Treatment ADD TreatmentDate DATETIME DEFAULT GETDATE() NOT NULL

INSERT INTO Treatment (Patient,Doctor) VALUES (1,1),(1,2),(2,2),(3,3),(4,4),(5,5),(6,6),(7,7),(8,7),(9,1)
INSERT INTO Treatment VALUES (2,NULL,3)


CREATE TABLE PatientTakesMedicine
(
Id INT CONSTRAINT PatientTakesMedicine_Id_pkAuto PRIMARY KEY IDENTITY(1,1),
Patient INT CONSTRAINT PatientTakesMedicine_Patient_Fk FOREIGN KEY REFERENCES Patients(PatientId) ON DELETE NO ACTION ON UPDATE CASCADE,
Drug INT CONSTRAINT PatientTakesMedicine_Drug_Fk FOREIGN KEY REFERENCES Drugs(DrugId) ON DELETE NO ACTION ON UPDATE CASCADE,
Timing INT CONSTRAINT PatientTakesMedicine_Timing_Fk FOREIGN KEY REFERENCES DrugTiming(TimingId) ON DELETE NO ACTION ON UPDATE CASCADE
)

ALTER TABLE PatientTakesMedicine 
	ADD Assistant INT 
		CONSTRAINT PatientTakesMedicine_Assistant_Fk FOREIGN KEY REFERENCES Assistants(AssistantId)

ALTER TABLE PatientTakesMedicine ADD StartDate DATETIME DEFAULT GETDATE() NOT NULL,
									EndDate DATETIME DEFAULT DATEADD(DD,7,GETDATE()) NOT NULL

INSERT INTO PatientTakesMedicine VALUES (1,1,1,1),(1,2,1,2),(1,1,3,3),(2,3,1,4),(3,4,3,5),(4,5,1,6),(5,1,1,7),
(6,1,1,1),(7,1,1,2),(8,1,1,3),(9,1,1,4)


SELECT * FROM Assistants
SELECT * FROM City
SELECT * FROM Departments
SELECT * FROM Doctors
SELECT * FROM Drugs
SELECT * FROM DrugTiming
SELECT * FROM Patients
SELECT * FROM PatientTakesMedicine
SELECT * FROM States
SELECT * FROM Treatment



ALTER VIEW PatientsPerDoctor
	AS
		SELECT d.DoctorId,d.FirstName+' '+d.LastName AS DrName,p.FirstName+' '+p.LastName AS PatientName
			FROM 
				Doctors d JOIN Treatment t ON t.Doctor=d.DoctorId 
				JOIN  Patients p ON p.PatientId=t.Patient


SELECT DoctorId,DrName,STRING_AGG(PatientName,','),COUNT(PatientName) AS NoOfPatients 
	FROM PatientsPerDoctor 
		GROUP BY DoctorId,DrName
			ORDER BY NoOfPatients DESC

SELECT DoctorId,DrName,PatientName
	FROM PatientsPerDoctor
		ORDER BY DoctorId