namespace ConsoleApp1.Lab1
{
    internal class Task5
    {
        public void Main()
        {
            Console.Write("Podaj liczbę elementów (n): ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Nieprawidłowa liczba elementów.");
                return;
            }

            int[] liczby = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Podaj liczbę nr {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out liczby[i]))
                {
                    Console.Write("Błąd. Wpisz poprawną liczbę całkowitą: ");
                }
            }
            SortowaniePrzezWstawianie(liczby);
            Console.WriteLine("\nWynik (sortowanie przez wstawianie):");

            Console.WriteLine(string.Join(", ", liczby));
        }

        static void SortowaniePrzezWstawianie(int[] tab)
        {
            int n = tab.Length;
            for (int i = 1; i < n; i++)
            {
                int klucz = tab[i];
                int j = i - 1;

                while (j >= 0 && tab[j] > klucz)
                {
                    tab[j + 1] = tab[j];
                    j--;
                }
                tab[j + 1] = klucz;
            }
        }

    }
}
