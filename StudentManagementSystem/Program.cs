using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("======= Menu =======");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Find Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");

            List<Student> students = new List<Student>();
            bool userAnswer;

            int number = 0;
            int enteredId;
            Student studentById;
            do
            {

                Console.Write("Chose a number from the menu: ");
                number = Convert.ToInt32(Console.ReadLine());


                switch (number)
                {
                    case 1:
                        Console.WriteLine("Welcome to add student page");
                        do
                        {
                            students.Add(AddStudent());
                            Console.WriteLine("do you want to add another student? ");
                            userAnswer = Convert.ToBoolean(Console.ReadLine());
                        } while (userAnswer == true);

                        break;

                    case 2:
                        Console.WriteLine("This is all the student in the page");
                        foreach (Student student in students)
                        {
                            Console.WriteLine(student.Id + " " + student.Name + " " + student.Age + " " + student.Major + " " + student.GPA);
                        }
                        break;


                    case 3:
                        Console.WriteLine("Find student id page: ");
                        System.Console.WriteLine("please enter student id: ");
                        enteredId = int.Parse(Console.ReadLine());


                        studentById = FindStudentById(students, enteredId);
                        if (studentById != null)
                        {
                            Console.WriteLine(studentById.Id + " " + studentById.Name + " " + studentById.Age + " " + studentById.Major + " " + studentById.GPA);
                        }
                        else
                        {
                            Console.WriteLine("the student you enter doesn`t exist");
                        }
                        break;

                    case 4:
                        Console.WriteLine("update student page: ");


                        System.Console.WriteLine("please enter student id: ");
                        enteredId = int.Parse(Console.ReadLine());


                        studentById = FindStudentById(students, enteredId);
                        if (studentById != null)
                        {
                            Console.WriteLine(studentById.Id + " " + studentById.Name + " " + studentById.Age + " " + studentById.Major + " " + studentById.GPA);
                            System.Console.WriteLine("please enter student new name: ");
                            string newEnteredName = (Console.ReadLine());
                            System.Console.WriteLine("please enter student new age: ");
                            int newEnteredAge = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("please enter student new GPA: ");
                            double newEnteredGpa = double.Parse(Console.ReadLine());
                            System.Console.WriteLine("please enter student new Major: ");
                            string newEnteredMajor = (Console.ReadLine());


                            Student updateStudent = UpdateStudent(studentById, newEnteredName, newEnteredAge, newEnteredMajor, newEnteredGpa);
                            Console.WriteLine(studentById.Id + " " + updateStudent.Name + " " + updateStudent.Age + " " + updateStudent.Major + " " + updateStudent.GPA);

                        }
                        else
                        {
                            Console.WriteLine("the student you enter doesn`t exist");
                        }

                        break;



                    case 5:
                        Console.WriteLine("delete student page: ");
                        System.Console.WriteLine("please enter student id: ");
                        enteredId = int.Parse(Console.ReadLine());


                        studentById = FindStudentById(students, enteredId);
                        if (studentById != null)
                        {
                            Console.WriteLine(studentById.Id + " " + studentById.Name + " " + studentById.Age + " " + studentById.Major + " " + studentById.GPA);

                            Console.WriteLine("Are you sure you want to delete this student? (yes/no)");
                            string answer = Console.ReadLine();

                            if (answer.ToLower() == "yes")
                            {
                                DeleteStudent(students, studentById);
                                Console.WriteLine("Student deleted successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Delete cancelled.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("the student you enter doesn`t exist");
                        }

                        break;

                    default:
                        break;
                }


            } while (number != 6);










        }

        public static Student FindStudentById(List<Student> students, int wantedId)
        {
            Student result = students.FirstOrDefault(Student => Student.Id == wantedId);
            return result;
        }

        public static Student UpdateStudent(Student student, string newName, int newAge, string newMajor, double newGpa)
        {
            student.Name = newName;
            student.Age = newAge;
            student.Major = newMajor;
            student.GPA = newGpa;

            return student;

        }

        public static Student AddStudent()
        {
            Console.WriteLine("Please Enter Student Info: ");
            System.Console.WriteLine("please enter student id: ");
            int enteredId = int.Parse(Console.ReadLine());
            System.Console.WriteLine("please enter student name: ");
            string enteredName = (Console.ReadLine());
            System.Console.WriteLine("please enter student age: ");
            int enteredAge = int.Parse(Console.ReadLine());
            System.Console.WriteLine("please enter student major: ");
            string enteredMajor = (Console.ReadLine());
            System.Console.WriteLine("please enter student gpa: ");
            double enteredGpa = double.Parse(Console.ReadLine());

            Student enteredStudent = new Student(enteredId, enteredName, enteredAge, enteredMajor, enteredGpa);
            return enteredStudent;
        }

        public static void DeleteStudent(List<Student> students, Student deleteStudent)
        {
            students.Remove(deleteStudent);
        }
    }
}