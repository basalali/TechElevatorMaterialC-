CREATE DATABASE ProjectManager;
 -- if you include identity, it genereates for you. PK is unique and not null.
 BEGIN TRANSACTION

CREATE TABLE Department
(
	department_id int IDENTITY,
	department_name nvarchar(60) NOT NULL,
	CONSTRAINT pk_depart_ID PRIMARY KEY (department_id),

)

CREATE TABLE employee
(
    employee_id int IDENTITY,
    job_title nvarchar(60) NOT NULL,
	last_name nvarchar(60) NOT NUll,
	first_name nvarchar(60) NOT NULL,
	gender nvarchar(60) NOT NULL,
	date_of_birth smallint NOT NULL,
	date_of_hire smallint NOT NULL,
	department_id int NOT NULL,
	employee_home_department nvarchar(60) NOT NULL,
	CONSTRAINT pk_employee_id PRIMARY KEY (employee_id),
	CONSTRAINT fk_department_id FOREIGN KEY (department_id) REFERENCES department(department_id),


)

CREATE TABLE Project
(
	project_id int IDENTITY,
	project_name nvarchar(60) NOT NULL,
	employee_id int NOT NULL,
	CONSTRAINT pk_project_id PRIMARY KEY (project_id),
	CONSTRAINT fk_employee_id FOREIGN KEY (employee_id) REFERENCES employee(employee_id)

)
COMMIT 

SELECT * FROM employee
SELECT * FROM Department
SELECT * FROM Project
------- Department Inserts -------
INSERT Department (department_name)
VALUES ('Finance')
INSERT Department (department_name)
VALUES ('Marketing')
INSERT Department (department_name)
VALUES ('Operations')


---- Employee Inserts ----
INSERT employee(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, employee_home_department)
VALUES ('President', 'Ali', 'Basal', 'Male', 10/10/1856, 08/15/15, 'Finance')

INSERT employee(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, employee_home_department)
VALUES ('President', 'Ali', 'Layla', 'Female', 10/10/1990, 08/15/19, 'Marketing')

INSERT employee(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, employee_home_department)
VALUES ('President', 'Smith', 'John', 'Male', 09/18/1985, 08/15/10, 'Operations')

INSERT employee(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, employee_home_department)
VALUES ('President', 'Ahmed', 'Jama', 'Male', 03/14/1995, 08/15/18, 'Finance')

INSERT employee(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, employee_home_department)
VALUES ('President', 'Watson', 'Jessica', 'FMale', 10/10/1800, 08/15/97, 'Marketing')

INSERT employee(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, employee_home_department)
VALUES ('President', 'Alba', 'Jessica', 'Female', 10/10/1856, 08/15/15, 'Operations')

INSERT employee(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, employee_home_department)
VALUES ('President', 'Ali', 'Basal', 'Male', 10/10/1856, 08/15/15, 'Finance')

INSERT employee(job_title, last_name, first_name, gender, date_of_birth, date_of_hire, employee_home_department)
VALUES ('President', 'Ali', 'Basal', 'Male', 10/10/1856, 08/15/15, 'Operations')

--------- Project Inserts
INSERT Project(project_name)
VALUES ('')

INSERT Project(project_name)
VALUES ('')

INSERT Project(project_name)
VALUES ('')

INSERT Project(project_name)
VALUES ('')

COMMIT 


SELECT * FROM employee
SELECT * FROM Department
SELECT * FROM Project