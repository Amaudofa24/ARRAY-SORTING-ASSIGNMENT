namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            int[] a = new int[] { 15, 10, 54, -4, 31, 4, -26, 10, -53, 84, 76 };

            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 11; j++)
                {
                    if (a[i] < a[j])
                    {
                        id = a[i];
                        a[i] = a[j];
                        a[j] = id;
                    }
                }
            }
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}