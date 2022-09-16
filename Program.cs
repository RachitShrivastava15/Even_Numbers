namespace EvenNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = 100;
            for(int i =0; i <=n; i++)
            {
                if (i %2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}