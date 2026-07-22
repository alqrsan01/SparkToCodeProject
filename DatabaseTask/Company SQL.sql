create database CompanyDB;


use CompanyDB;

create table Employee (
	Ssn int primary key identity (1, 1),
	Fname varchar(30) not null,
	Minit char(1),
	Lname varchar(30) not null,
	Bdate Date,
	EAddress varchar(100),
	Sex char(1),
	Salary decimal(10, 2) constraint CK_Employee_Salary check(Salary > 0),
	Super_ssn int,
	Dno int,
	
	foreign key (Super_ssn) references Employee(Ssn),
);

create table Department (
	Dname varchar(20) not null unique,
	Dnumber int primary key identity(1, 1),
	Mgr_ssn int,
	Mgr_start_date date,

	foreign key (Mgr_ssn) references Employee(Ssn),
);

create table Dept_Location (
	Dnumber int,
	Dlocation varchar(100) not null,

	primary key (Dnumber, Dlocation),
	foreign key (Dnumber) references Department(Dnumber) on delete cascade,
);

create table Project (
	Pname varchar(20) not null unique,
	Pnumber int primary key identity(1, 1),
	Plocation varchar(100),
	Dnum int not null,

	foreign key (Dnum) references Department(Dnumber),
);

create table Work_On (
	Essn int,
	Pno int,
	Hrs decimal(5, 1) not null constraint CK_WorksOn_Hrs check(Hrs >= 0),
	
	primary key (Essn, Pno),
	foreign key (Essn) references Employee(Ssn) on delete cascade,
	foreign key (Pno) references Project(Pnumber) on delete cascade,
);

create table Dependent (
	Essn int,
	Deprndent_name varchar(20) not null,
	Sex char(1) constraint CK_Dependent_Sex check(Sex in ('M', 'F')),
	Bdate date,
	Relationship varchar(20),

	primary key (Essn, Deprndent_name),
	foreign key (Essn) references Employee(Ssn) on delete cascade,
);

insert into Department(Dname, Mgr_ssn, Mgr_start_date)
values ('Headquarters', null, null), ('Research', null, null), ('Administration', null, null);

insert into Dept_Location(Dnumber, Dlocation)
values (1, 'Nizwa'), (2, 'Muscat'), (3, 'Sur'), (4, 'Sohar');

insert into Employee(Fname, Minit, Lname, Bdate, Sex, Salary, Super_ssn, Dno)
values ('Hassan', 'E', 'Jamal', '1937-11-10', 1, 3500.00, null, 1), 
       ('Mohammed', 'B', 'Said', '1965-01-09', 1, 3000.00, 1, 2),  
       ('Ahmed', 'S', 'Ali', '1990-05-31', 1, 2100.00, 2, 2),  
       ('Ali', 'A', 'Salim', '1995-03-14', 0, 1800.00, 2, 2),   
       ('Hamed', 'K', 'Rashdi', '1988-07-22', 0, 1500.00, 1,  3); 

update Department set Mgr_ssn = 1, Mgr_start_date = '1981-06-19' where Dnumber = 1;
update Department set Mgr_ssn = 2, Mgr_start_date = '1988-05-22' where Dnumber = 2;
update Department set Mgr_ssn = 5, Mgr_start_date = '2000-01-01' where Dnumber = 3;

insert into Project(Pname, Plocation, Dnum)
values	('Product1', 'Nizwa', 2),
		('Product2', 'Muscat', 2),
		('Product3', 'Sur', 3),
		('Product4', 'Sohar', 1);

insert into Work_On(Essn, Pno, Hrs)
values	(3, 1, 32.5),
		(3, 2, 7.5),
		(4, 1, 40.0),
		(4, 2, 10.0),
		(2, 3, 5.0),
		(1, 4, 16.0),
		(5, 3, 35.0),
		(5, 4, 15.0);

insert into Dependent(Essn, Deprndent_name, Sex, Bdate, Relationship)
values	(2, 'Hassan', 'F', '1986-04-05', 'Son'),
		(2, 'Ali', 'F', '1968-05-03', 'Spouse'),
		(3, 'Khalid', 'M', '2015-06-30', 'Son'),
		(4, 'Mohammed', 'F', '2018-09-10', 'Son'),
		(1, 'Said', 'F', '1940-02-14', 'Spouse');

update Employee set Salary += 200;
update Employee set Salary += 100 where Ssn = 3;
update Employee set EAddress = 'Muscat' where Salary > 2000;
update Employee set Dno = 3 where Ssn = 4;
update Project set Plocation = 'Nizwa' where Pname = 'Product67';

delete from Work_On where Essn = 4 and Pno = 2;
update Department set Mgr_ssn = null, Mgr_start_date = null where Mgr_ssn = 2;
delete from Employee where Ssn = 2;

select * from Employee;
select * from Department;
select * from Dept_Location;
select * from Project;
select * from Work_On;
select * from Dependent;