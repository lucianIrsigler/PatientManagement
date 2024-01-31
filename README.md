# Purpose of the project
The purpose of the project is to create a basic patient management system. The project's aim is to improve my usage
of PostgreSQL and wpf C#.

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
![Class diagram](https://github.com/lucianIrsigler/PatientManagement/blob/master/images/classdiagram.PNG)

## ERD
![Entity relation diagram](https://github.com/lucianIrsigler/PatientManagement/blob/master/images/erd.PNG)
