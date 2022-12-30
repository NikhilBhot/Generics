namespace UC_03_FindMaxFromThreeInteger
{
    internal class Program
    {

        public static int MaxIntNum(int fvalue,int sValue,int tValue)
        {
            if(fvalue.CompareTo(sValue) > 0 && fvalue.CompareTo(tValue) >0 ||
                fvalue.CompareTo(sValue)>=0 && fvalue.CompareTo(tValue)>0 ||
                fvalue.CompareTo(sValue)>0 && fvalue.CompareTo(tValue) >=0)
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
           int max= Program.MaxIntNum(1,2,3);
            Console.WriteLine(max);
        }
    }
}