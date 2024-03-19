namespace rec
{
    internal class nums
    {
        public static void st()
        {
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int summm = 0;
            sum(n);
            Console.WriteLine(summm);
            void sum(int x)
            {
                if (x > 0)
                {
                    summm += x % 10;
                    x /= 10;
                    sum(x);
                }
            }
        }
    }
}