using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_Array_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userInput = string.Empty;
            string name = string.Empty;
            int userAnzahl = 0;
            bool userInputinValid = false;
            DateTime birthday = DateTime.MinValue;


            string[] names;
            DateTime[] birthdays;
            int[] postalcodes;
            string[] adresses;


            // user anzahl nachfragen und umwandeln
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Hallo, wie viele Studenten sollten eingetragen werden:");
                Console.ForegroundColor = ConsoleColor.Green;
                userInput = Console.ReadLine();

                try
                {
                    userAnzahl = int.Parse(userInput);
                    userInputinValid = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    userInputinValid = true;
                } 
            } while (userInputinValid);
            Console.Clear();

            // Arrays auf die passende userAnzahl größe einfügen
            names = new string[userAnzahl];
            birthdays = new DateTime[userAnzahl];
            postalcodes = new int[userAnzahl];
            adresses = new string[userAnzahl];


            for (int i = 0; i < names.Length; i++)
            {
                // für die lesbar keit ++i damit der 1 student auch bei 1 anfängt danach i-- um die korrekte anwedung der Variable zu haben
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("bitte gib folgende daten vom " + ++i + "ten Studenten ein\t");
                i--;

                // name anfragen
                Console.Write("\tName:                     ");
                Console.ForegroundColor = ConsoleColor.Green;
                names[i] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                // geburtstag nachfragen und diesen von string in DateTime umwandeln
                


                do
                {
                    Console.Write("\tGeburtstag(MM.dd.yyyy):   ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    userInput = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    
                        try
                        {
                            birthday = DateTime.Parse(userInput);
                            birthdays[i] = birthday;
                            userInputinValid = false;
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: " + ex.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                            userInputinValid = true;
                        } 

                } while (userInputinValid);


                do
                {
                    //postal code eintragen und diesen von String in ein inteter umwandeln bei fehler eingabe eine exception
                    Console.Write("\tPostal Code:              ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    userInput = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;


                        try
                        { 
                            postalcodes[i] = int.Parse(userInput);
                            userInputinValid = false;
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: " + ex.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                            userInputinValid = true;

                        } 

                } while (userInputinValid);

                //Adrese  an stelle i eingeben
                Console.Write("\tAdress:                   ");
                Console.ForegroundColor = ConsoleColor.Green;
                adresses[i] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

            }


            // daten ausgeben die eingetragen wurden
            Console.WriteLine("Das sind die Daten:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Student " + ++i + ":");
                i--;
                Console.WriteLine("Name: " + names[i]);
                Console.WriteLine("Birthday: " + birthdays[i].ToString("dd /MM/yyyy"));
                Console.WriteLine("Adress: " + adresses + postalcodes[i].ToString());
                Console.WriteLine();

            }
    
        }
    }
}
