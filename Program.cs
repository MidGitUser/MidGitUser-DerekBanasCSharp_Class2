using System;
using System.Text; // ** For String
using System.Globalization; // ** For culture specific formatting
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DerekBans_CSharp_Class_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Implicit Typing
            var intVal = 444;

            Console.WriteLine("Type of variable is: {0}", intVal.GetType());


            // ARRAY EXAMPLE
            int[] favNums = new int[3];
            favNums[0] = 222;

            Console.WriteLine("favNum[0] = {0}", favNums[0]);

            // string Array
            string[] customers = { "Bob", "mark", "tyson" };

            var emp = new[] { "mike", "sara", "rick" };

            object[] randomArray = { "paul", 34, 2.41 };

            Console.WriteLine("Type of randomArray[0] = {0}", randomArray[0].GetType());
            Console.WriteLine("Type of randomArray[1] = {0}", randomArray[1].GetType());
            Console.WriteLine("Type of randomArray[2] = {0}", randomArray[2].GetType());

            Console.WriteLine("-----------------------------");
            // Array Length
            Console.WriteLine("Length Of Array: {0}", randomArray.Length);
            Console.WriteLine("-----------------------------");
            // Loop Array Items
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Array {0} : Value : {1}", i, randomArray[i]);
            }
            Console.WriteLine("-----------------------------");

            // MULTIDIMENSIONAL ARRAY
            string[,] custNames = new string[2, 2] { { "Bob", "Jack" }, { "Mark", "Paul" }};

            // -> Getting Single Value
            Console.WriteLine("Get Single Value: {0}", custNames.GetValue(1,1));
            Console.WriteLine("-----------------------------");
            // -> MULTIDIMENSIONAL LOOOP
            for (int i = 0; i < custNames.GetLength(0); i++)
            {
                for (int j = 0; j < custNames.GetLength(1); j++)
                {
                    Console.WriteLine("Value: {0}", custNames[i, j]);
                }

            }


            Console.WriteLine("-----------------------------");

            // FOREACH WWITH ARRAY
            int[] randNums = { 1, 4, 6, 3 };

            PrintArray(randNums, "For Each Loop");
            // ** PrintArray() Define Below

            Console.WriteLine("-----------------------------");
            // ARRAY SORT
            Array.Sort(randNums);
            PrintArray(randNums, "SortedArray");

            Console.WriteLine("-----------------------------");
            // ARRAY REVERSE
            Array.Reverse(randNums);
            PrintArray(randNums, "ReversedArray");


            Console.WriteLine("-----------------------------");
            // ARRAY: FIND INDEX
            Console.WriteLine("Index of 6: {0}", Array.IndexOf(randNums, 6));

            Console.WriteLine("-----------------------------");
            // ARRAY: Change at index
            randNums.SetValue(0, 1);


            // ARRAY: Copy Araay
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[3];
            int startInd = 0;
            int length = 3;

            Array.Copy(srcArray, startInd, destArray, startInd, length);

            PrintArray(destArray, "Destination Array");

            
            Console.WriteLine("-----------------------------");
            
            // -> Copy Array With INSTANCE
            Array newArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(newArray, 3);

            
            foreach (var item in newArray)
            {
                if (Convert.ToInt32(item) > 0)
                {
                    Console.WriteLine("old Array Item:  {0}", item);
                    
                }
                else
                {
                    Console.WriteLine("New Array Item: {0}", item);
                }
            }

            Console.WriteLine("-----------------------------");

            // -> PREDICATE
            int[] numArray = { 1, 11, 22 };
            Console.WriteLine("First value > than 10 in Array: {0} ", Array.Find(numArray, isGreaterThan10));
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Index of first value > than 10 in an Array: {0} ", Array.FindIndex(numArray, isGreaterThan10));

           

            Console.WriteLine("-----------------------------");

            // STRING BUILDER EXAMPLE
            StringBuilder sb = new StringBuilder("Random Text");
            StringBuilder sb2 = new StringBuilder("More Stuff that is important", 256);

            Console.WriteLine("Capacity: {0}", sb.Capacity);
            Console.WriteLine("Capacity: {0}", sb2.Capacity);



            Console.WriteLine("-----------------------------");
            Console.WriteLine("Length: {0}", sb.Length);

            Console.WriteLine("-----------------------------");
            
            // APPEND
            sb2.AppendLine("\nAnother Line");
            Console.WriteLine(sb2);

            // REPLACE
            Console.WriteLine("-----------------------------");
            sb.Replace("Text", "characters");
            Console.WriteLine(sb.ToString());


            // EQUALS
            Console.WriteLine("-----------------------------");
            Console.WriteLine(sb.Equals(sb2));


            // INSERT
            Console.WriteLine("-----------------------------");
            sb.Insert(11, "----");
            Console.WriteLine(sb);

            Console.WriteLine("-----------------------------");
            // REMOVE
            sb.Remove(4,13);
            Console.WriteLine(sb);

            */

            // CASTING 
            long num1 = 1234;
            int num2 = (int)num1;

            Console.WriteLine("Orig : {0} -------- Cast : {1}", num1.GetType(), num2.GetType());

            // :2
            Console.ReadKey();
        }

        private static void PrintArray(int[] intArray, string msg)
        {
            foreach (var item in intArray)
            {
                Console.WriteLine("{0}: {1}", msg, item);
            }
        }

        private static bool isGreaterThan10(int val)
        {
            return val > 10;
        }
    }
}