using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp_v2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCount = 0;

            Student[] studentList;

            // get count of students from user
            studentCount = GetInt("\nPlease enter count of Students: ");

            //retrieve all student data from user
            studentList = GetStudentData(studentCount);

            //output student data
            PrintStudentData(studentList);

            WriteStudentData(studentList, "myStudentList.json");

        }

        private static void WriteStudentData(Student[] studentList, string filename)
        {
            //homework
        }

        private static Student[] GetStudentData(int countOfStudents)
        {

            Student[] studentList = new Student[countOfStudents];

            for (int i = 0; i < countOfStudents; i++)
            {

                Console.WriteLine("\nbitte gib folgende daten vom " + (i + 1) + "ten Studenten ein\t");
                Console.WriteLine();

                studentList[i].Name = GetString("\tName:\t\t");

                studentList[i].Birthday = GetDateTime("\tBirthdate:\t");

                studentList[i].PostalCode = GetInt("\tPostal code:\t");

                studentList[i].City = GetString("\tCity:\t\t");

            }
            return studentList;
        }

        private static void PrintStudentData(Student[] studentList)
        {

            Console.ResetColor();

            Console.WriteLine("Das sind die Daten:");

            for (int i = 0; i < studentList.Length; i++)
            {
                Console.WriteLine("Student " + (i + 1) + ":");
                Console.WriteLine("Name: " + studentList[i].Name);
                Console.WriteLine("Birthday: " + studentList[i].Birthday.ToString("dd/MM/yyyy"));
                Console.WriteLine("Adresse: " + studentList[i].City.ToString() + " " + studentList[i].PostalCode.ToString());
                Console.WriteLine();
            }
        }

        private static string GetString(string inputPrompt) 
        {
            string userInput = string.Empty;

            Console.Write(inputPrompt);
            Console.ForegroundColor = ConsoleColor.Green;
            
            userInput = Console.ReadLine();
            Console.ResetColor();

            return userInput;
        }

        private static DateTime GetDateTime(string inputPrompt)
        {
            string userInput = string.Empty;
            DateTime Birthday = DateTime.MinValue;
            bool userInputinValid = false;


            do
            {
                Console.ResetColor();
                Console.Write(inputPrompt);
                Console.ForegroundColor = ConsoleColor.Green;
                userInput = Console.ReadLine();

                try
                {
                    Birthday = DateTime.Parse(userInput);
                    userInputinValid = false;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: " + ex.Message);
                    userInputinValid = true;
                }

            } while (userInputinValid);
            Console.ResetColor();
            return Birthday;
        }

        private static int GetInt(string inputPrompt)
        {
            string userInput = string.Empty;
            int intValue = 0;
            bool userInputinValid = false;

            do
            {
                Console.ResetColor();
                Console.Write(inputPrompt);
                Console.ForegroundColor = ConsoleColor.Green;
                userInput = Console.ReadLine();
                
                try
                {
                    intValue = int.Parse(userInput);
                    userInputinValid = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    userInputinValid = true;
                }
            } while (userInputinValid);

            Console.ResetColor();

            return intValue;
        }
    }
}
