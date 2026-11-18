namespace ConsoleApp1.Lab2
{
    internal class Licz
    {
        private int value;
        public Licz(int wartoscPoczatkowa)
        {
            value = wartoscPoczatkowa;
        }
        public void Dodaj(int liczba) {
            value += liczba;
        }
        public void Odejmij(int liczba) { 
            value -= liczba;
        }
        public void WyswietlStan()
        {
            Console.WriteLine($"Wartość elementu: {value}");
        }

    }
}
