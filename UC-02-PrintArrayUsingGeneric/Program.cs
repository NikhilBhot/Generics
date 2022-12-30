namespace UC_02_PrintArrayUsingGeneric
{
    public class Program
    {

        public static void toPrint<T>(T[] array)
        {
            foreach(var element in array)
            {
                System.Console.WriteLine(element);
            }
            Console.WriteLine("_________________________________");
        }
        static void Main(string[] args)
        {

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray= { 1.1, 2.1, 3.1 };
            char[] charArray = { 'a', 'b', 'c' };

            Program.toPrint<int>(intArray);
            Program.toPrint<double>(doubleArray);
            Program.toPrint<char>(charArray);
        }
    }
}