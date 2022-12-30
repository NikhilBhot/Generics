namespace UC_04_FindMaxFromThreeFloat
{
    internal class Program
    {

        public static float MaxFloatNum(float fvalue, float sValue, float tValue)
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
            float max = Program.MaxFloatNum(1.1f, 2.1f, 3.1f);
            Console.WriteLine(max);
        }
    }
}