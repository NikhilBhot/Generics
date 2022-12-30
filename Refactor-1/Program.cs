namespace Refactor_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Problem using Generics");

            double n = RefactorCode1<double>.MaxValue(50.5, 45.6, 48.5);
            int a = RefactorCode1<int>.MaxValue(70, 60, 50);
            string c = RefactorCode1<string>.MaxValue("Peach", "Apple", "Banana");



            Console.WriteLine("Maximum int in is: {0}", a);
            Console.WriteLine("Maximum Number in float is: {0}", n);
            Console.WriteLine("Maximum value in string is: {0}", c);
        }
    }
}