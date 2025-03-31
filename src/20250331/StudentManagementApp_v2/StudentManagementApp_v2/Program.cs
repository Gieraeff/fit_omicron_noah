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

            

            string userInput = string.Empty;
            int studentAnzahl = 0;
            bool userInputinValid = false;

            

            // user anzahl nachfragen und umwandeln
            do
            {
                Console.ResetColor();
                Console.WriteLine("Hallo, wie viele Studenten sollten eingetragen werden:");
                Console.ForegroundColor = ConsoleColor.Green;
                userInput = Console.ReadLine();

                try
                {
                    studentAnzahl = int.Parse(userInput);
                    userInputinValid = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    userInputinValid = true;
                }
            } while (userInputinValid);
            Console.Clear();


            Student[] studentList = new Student[studentAnzahl];


            for (int i = 0; i < studentList.Length; i++)
            {
                // für die lesbarkeit ++i damit der 1 student auch bei 1 anfängt danach i-- um die korrekte anwedung der Variable zu haben
                Console.ResetColor();
                Console.WriteLine("bitte gib folgende daten vom " + (i + 1) + "ten Studenten ein\t");

                // name anfragen
                Console.Write("\tName:                     ");
                Console.ForegroundColor = ConsoleColor.Green;
                studentList[i].Name = Console.ReadLine();


                // geburtstag nachfragen und diesen von string in DateTime 
                do
                {
                    Console.ResetColor();
                    Console.Write("\tGeburtstag(dd.MM.yyyy):   ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    userInput = Console.ReadLine();

                    try
                    {
                        studentList[i].Birthday = DateTime.Parse(userInput);
                        userInputinValid = false;
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: " + ex.Message);
                        userInputinValid = true;
                    }

                } while (userInputinValid);


                do
                {
                    Console.ResetColor();
                    //postal code eintragen und diesen von String in ein inteter umwandeln bei fehler eingabe eine exception
                    Console.Write("\tPostal Code:              ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    userInput = Console.ReadLine();


                    try
                    {
                        studentList[i].PostalCode = int.Parse(userInput);
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
                //Adrese  an stelle i eingeben
                Console.Write("\tAdress:                   ");
                Console.ForegroundColor = ConsoleColor.Green;
                studentList[i].City = Console.ReadLine();


            }

            Console.ResetColor();
            // daten ausgeben die eingetragen wurden
            Console.WriteLine("Das sind die Daten:");
            for (int i = 0; i < studentList.Length; i++)
            {
                Console.WriteLine("Student " + (i + 1) + ":");
                Console.WriteLine("Name: " + studentList[i].Name);
                Console.WriteLine("Birthday: " + studentList[i].Birthday.ToString("dd/MM/yyyy"));
                Console.WriteLine("Adress: " + studentList[i].City.ToString() + " " + studentList[i].PostalCode.ToString());
                Console.WriteLine();
            }

        }
    }
}
