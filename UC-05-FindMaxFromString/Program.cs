namespace UC_05_FindMaxFromString
{
    internal class Program
    {

        public static string MaxIntNum(string fvalue, string sValue, string tValue)
        {
            if (fvalue.CompareTo(sValue) > 0 && fvalue.CompareTo(tValue) > 0 ||
                fvalue.CompareTo(sValue) >= 0 && fvalue.CompareTo(tValue) > 0 ||
                fvalue.CompareTo(sValue) > 0 && fvalue.CompareTo(tValue) >= 0)
            {
                return fvalue;
            }

            if (sValue.CompareTo(fvalue) > 0 && sValue.CompareTo(tValue) > 0 ||
                sValue.CompareTo(fvalue) >= 0 && sValue.CompareTo(tValue) > 0 ||
                sValue.CompareTo(fvalue) > 0 && sValue.CompareTo(tValue) >= 0)
            {
                return sValue;
            }

            if (tValue.CompareTo(fvalue) > 0 && tValue.CompareTo(sValue) > 0 ||
                tValue.CompareTo(fvalue) >= 0 && tValue.CompareTo(sValue) > 0 ||
                tValue.CompareTo(fvalue) > 0 && tValue.CompareTo(sValue) >= 0)
            {
                return tValue;
            }
            return fvalue;
        }
        static void Main(string[] args)
        {
            string max = Program.MaxIntNum("Hello", "Nikhil", "Demo");
            Console.WriteLine(max);
        }
    }
}
