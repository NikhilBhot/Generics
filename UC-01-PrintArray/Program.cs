/*
 * Given an array of Integer,
Double and Character, write
a program to print the same - Create PrintArray class and define
toPrint method to print
corresponding elements to console
 */

namespace UC_01_PrintArray
{
    class Program
    {
       public static void toPrint(int[] inputArray)
        {
            foreach(int element in inputArray)
            {
                Console.WriteLine(element);
            }
            //Console.WriteLine("_____________________________________");
        }
        public static void toPrint(double[] inuputArray)
        {
            foreach(double element in inuputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("___________________________");

        }
        public static void toPrint(char[] inuputArray)
        {
            foreach (char element in inuputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("___________________________");

        }

        public static void Main(String[]args)
        {
            int[] intArray = { 1, 2, 3};
            double[] doubleArray = { 1.1, 1.2, 1.3 };
            char[] charArray = { 'a', 'b', 'c', 'd', };

            Program.toPrint(intArray);
            Program.toPrint(doubleArray);
            Program.toPrint(charArray);

        }
    }
}