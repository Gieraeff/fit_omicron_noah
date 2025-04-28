using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOFNames = CreateStringArray(10, "No Name");

            //var listOfYearOfBirth = CreateIntArray(10, 1880);

            listOFNames = CreateArray<string>(15, string.Empty);

            var ListOFYearOfBirths = CreateArray<int>(10, 1880);

            List<string> nameList = new List<string>();

            nameList.Add("gandalf th grey");
            
        }
        
        private static T[] CreateArray<T>(int itemCount, T initValue)
        {
            var valuelist = new T[itemCount];

            for (int i = 0; i < itemCount; i++)
            {
                valuelist[i] = initValue;
            }
            return valuelist;
        }

        private static string[] CreateStringArray(int itemCount, string initValue)
        {
            var valueList = new string[itemCount];

            for (int i = 0; i < itemCount; i++)
            {
                valueList[i] = initValue;
            }

            return valueList;
        }
    }
}
