namespace ConsoleApp1.Lab1
{
    internal class Task3
    {

        public void ShowNumbers()
        {
            int[] wykluczone = [2, 6, 9, 15, 19];
            for (int i = 20; i >= 0; i--)
            {
                if (wykluczone.Contains(i))
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
