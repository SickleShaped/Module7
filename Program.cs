namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = a.GetNegative();
            Console.WriteLine(b);
        }

    }

    static class Extension
    {
        public static int GetPositive(this int source)
        {
            if(source<0)
            {
                return -source;
            }
            else { return source; }
        }

        public static int GetNegative(this int source)
        {
            if (source > 0)
            {
                return -source;
            }
            else { return source; }
        }
    }

}