namespace ConsoleApp1
{
    internal class Task4
    {
        public void ShowNumbers()
        {

            while (true)
            {
                Console.WriteLine("Podaj liczbę całkowitą");
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    break;
                }
            }
        }
    }
}
