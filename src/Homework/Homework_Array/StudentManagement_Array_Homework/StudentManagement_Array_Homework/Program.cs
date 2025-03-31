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
            //string name = string.Empty;
            int userAnzahl = 0;
            bool userInputinValid = false;
            //DateTime birthday = DateTime.MinValue;


            string[] nameList;
            DateTime[] birthdayList;
            int[] postalcodeList;
            string[] adressList;


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
            nameList = new string[userAnzahl];
            birthdayList = new DateTime[userAnzahl];
            postalcodeList = new int[userAnzahl];
            adressList = new string[userAnzahl];


            for (int i = 0; i < nameList.Length; i++)
            {
                // für die lesbarkeit ++i damit der 1 student auch bei 1 anfängt danach i-- um die korrekte anwedung der Variable zu haben
                Console.ResetColor();
                Console.WriteLine("bitte gib folgende daten vom " + (i+1) + "ten Studenten ein\t");

                // name anfragen
                Console.Write("\tName:                     ");
                Console.ForegroundColor = ConsoleColor.Green;
                nameList[i] = Console.ReadLine();
                

                // geburtstag nachfragen und diesen von string in DateTime umwandeln

                do
                {
                    Console.ResetColor();
                    Console.Write("\tGeburtstag(dd.MM.yyyy):   ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    userInput = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    
                        try
                        {
                            birthdayList[i] = DateTime.Parse(userInput);
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
                            postalcodeList[i] = int.Parse(userInput);
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
                adressList[i] = Console.ReadLine();
                

            }

            Console.ResetColor();
            // daten ausgeben die eingetragen wurden
            Console.WriteLine("Das sind die Daten:");
            for (int i = 0; i < nameList.Length; i++)
            {
                Console.WriteLine("Student " + (i+1) + ":");
                Console.WriteLine("Name: " + nameList[i]);
                Console.WriteLine("Birthday: " + birthdayList[i].ToString("dd/MM/yyyy"));
                Console.WriteLine("Adress: " + adressList[i].ToString() + " " + postalcodeList[i].ToString());
                Console.WriteLine();


            }
    
        }
    }
}
