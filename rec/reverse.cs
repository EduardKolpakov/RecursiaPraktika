namespace rec
{
    internal class reverse
    {
        public static void st()
        {
            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            rev(a);
            void rev(int x)
            {
                if (x != 0)
                {
                    Console.Write($"{x % 10} ");
                    rev(x / 10);
                }
            }
        }
    }
}