namespace rec
{
    internal class count
    {
        public static void st()
        {
            Console.WriteLine("Введите число а: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c: ");
            int c = int.Parse(Console.ReadLine());
            if (a < b)
            {
                first(a);
            }
            else if (a > b)
            {
                second(c);
            }
            else
            {
                first(a);
            }
            void first(int i)
            {
                if (i <= c)
                {
                    Console.WriteLine(i);
                    first(i + 1);
                }
            }
            void second(int i)
            {
                if (i >= a)
                {
                    Console.WriteLine(i);
                    second(i - 1);
                }
            }
        }
    }
}