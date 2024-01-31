# Purpose of the project
The purpose of the project is to create a basic patient management system. The project's aim is to improve my usage
of PostgreSQL and wpf C#.
**It is still a work in progress**

# The project outline
The project idea is from w3schools.

The premise of the project is that we need to create a desktop application to allow a company to manage their
patient base in an effective manner.

There are 3 users in this system, namely:
1) Admin
2) Employee
3) Doctor

Each user has different permissions with regards to data.

## Admin
A admin has the capability to:
- Execute all CRUD operations on any users,except for admins
- A superadmin is one who has the ability to do CRUD operations on other admins

## Doctor
A doctor has the capability to:
- Create/Update/Delete/Remove consultations
- Add/update patients
- View patient/consultation information

## Employee
A employee has the capability to:
- View patient/consultation information
- Create/Update/Delete/Remove consultations

# Database design
The database manager used is PostgreSQL.

## The class diagram
![Class diagram](https://github.com/lucianIrsigler/PatientManagement/blob/master/images/classdiagram.png)

## ERD
![Entity relation diagram](https://github.com/lucianIrsigler/PatientManagement/blob/master/images/erd.png)

There is inheritence between the entities of Employee,Admin,Worker,and Doctor, due to the fact that each require the same
basic data(EmployeeID,StartingDate...). Thus to simplify the ERD, I used inheritence.

# Human views
## Employee View
The employee home screen looks like this:
![Home screen](https://github.com/lucianIrsigler/PatientManagement/blob/master/images/employee0.png)

Majority of the screens look similar to this.DataGrids are used to store the rows that are retrieved from the 
database

# Programming and issues
I utilized custom UserControls to provide abstraction for the xaml files.

However, I encountered an issue with one of the menus. If you look at the Employee Home Screen, you will notice a 
menu on the left hand side. This menu had to be created with a stackpanel with buttons to get what I wanted.

The issue was with binding the on click handlers to the buttons. I tried to think of the most programmatic approach to
the issue but fell short. I had to thus then come up a bandaid fix where I pasted the onclick handler functionility into
each of the WPF page's constructor.

It did work and since the code for the onclick handlers shouldn't change, then its a suitable solution at the moment.

# Skills practiced
This project allowed me to practice on:
- Seperating related files into different folders
- Custom UserControls and implementing them into other xaml files and fixing issues with them
- ERD/class diagram practice
- Designing layouts using xaml
- Usage of DataGrids and DataTable sorting to retrieve rows
- Usage of the NuGet package "Npgsql"
- Inheritence with C#
