# Student Management System

A simple console-based Student Management System built with C#.

This project was created as a practical project to consolidate and apply the C# concepts learned during Phase 1, Phase 2 (OOP), and Phase 3 of my C# learning journey.

## 📌 Project Overview

The application allows users to manage students through a simple console menu.

Users can:

- Add new students
- View all students
- Find a student by ID
- Update student information
- Delete a student
- Confirm before deleting a student
- Exit the application

Student data is stored in memory using a `List<Student>`.

## 🛠️ Technologies

- C#
- .NET
- Console Application
- LINQ
- Generic Collections

## 📚 Concepts Applied

### C# Basics

- Variables
- Data Types
- Console Input / Output
- Conditional Statements
- Loops
- Methods
- `switch` statements

### Object-Oriented Programming

- Classes
- Objects
- Constructors
- Properties
- Encapsulation
- Inheritance

### Collections & Generics

- `List<T>`
- Generic types
- Adding objects to a list
- Removing objects from a list
- Iterating through collections using `foreach`

### LINQ

LINQ is used to search for students by their ID.

Example:

```csharp
Student result = students.FirstOrDefault(Student => Student.Id == wantedId);

FirstOrDefault() returns the first student that matches the specified ID. If no student is found, it returns null.

🔄 CRUD Operations

The project implements the basic CRUD operations:

Operation	Description
Create	Add a new student
Read	View and find students
Update	Update student information
Delete	Delete a student
🏗️ Project Structure
StudentManagementSystem
│
├── Models
│   ├── Person.cs
│   └── Student.cs
│
└── Program.cs
Person.cs

The Person class is the base class and contains the common properties shared by people in the system:

Id
Name
Age
Student.cs

The Student class inherits from Person and adds student-specific properties:

Major
GPA

The inheritance relationship allows Student to reuse the common properties defined in Person.

Program.cs

Contains the main application logic, including:

Console menu
User input
Student management operations
CRUD operations
LINQ search
switch statement
User confirmation before deletion
🎯 Application Menu
======= Menu =======
1. Add Student
2. View Students
3. Find Student
4. Update Student
5. Delete Student
6. Exit
➕ Add Student

The user can enter the following information:

Student ID
Student Name
Student Age
Student Major
Student GPA

A new Student object is created using the constructor and then added to the List<Student>.

🔎 Find Student

The application asks the user for a student ID and uses LINQ FirstOrDefault() to search the list.

If the student exists, their information is displayed.

If the student does not exist, the application displays a message indicating that the student could not be found.

✏️ Update Student

The user enters the student's ID first.

If the student exists, the application asks for the new:

Name
Age
Major
GPA

The existing student's properties are then updated.

🗑️ Delete Student

The user enters the student's ID.

If the student exists, their information is displayed and the application asks for confirmation:

Are you sure you want to delete this student? (yes/no)

If the user enters yes, the student is removed from the list.

If the user enters another answer, the deletion is cancelled.

The actual deletion is handled by:

students.Remove(deleteStudent);
💡 What I Learned

This project helped me practice combining multiple C# concepts into one working application rather than studying each concept separately.

The main concepts practiced were:

Modeling real-world entities using classes and objects
Using constructors to create objects
Applying encapsulation through properties
Using inheritance between classes
Working with generic collections
Using List<Student> to store multiple objects
Using LINQ to search collections
Creating reusable methods for application operations
Implementing CRUD functionality
Controlling application flow using a menu and switch
Handling cases where a searched student does not exist
Adding user confirmation before deleting data


👨‍💻 Author

Eyad Adnan Makkawi.