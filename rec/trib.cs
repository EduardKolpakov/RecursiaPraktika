namespace rec
{
    internal class trib
    {
        public static void st()
        {
            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            tribonacci(a);
            void tribonacci(int n)
            {
                List<int> list = new List<int>() { 0, 0, 1 };
                if (n > 0 & n <= 2)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    for (int i = 3; i < n; i++)
                    {
                        list.Add(list[i - 3] + list[i - 2] + list[i - 1]);
                    }
                    Console.WriteLine(list.Last());
                }
            }
        }
    }
}