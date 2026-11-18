
namespace ConsoleApp1.Lab2
{
    
    internal class Sumator
    {
        private int[] liczby;

        public int[] Liczby {  get { return liczby; } 
            set { 
                if(value == null)
                {
                    throw new ArgumentNullException("Nie może być wartość null.");
                }
                liczby = value; } }
        public Sumator(int[] liczby)
        {
            Liczby = liczby;
            this.liczby = (int[])liczby.Clone();
        }

        public int Suma()
        {
            int wynik = 0;
            for (int i = 0; i < liczby.Length; i++)
            {
                wynik += liczby[i];
            }
            return wynik;
        }

        public int SumaPodzielnychPrzez2()
        {
            int wynik = 0;
            for (int i = 0; i < liczby.Length; i++)
            {
                if (liczby[i] % 2 == 0) {
                    wynik += liczby[i];
                }

                
            }
            return wynik;
        }

        public int IleElementow() {
            return liczby.Length;
        }

        public void WypiszWszystkie()
        {
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.WriteLine($"Liczba numer {i+1}: {liczby[i]}");

            }
        }

        public void WypiszZakres(int lowIndex, int highIndex)
        {
            List<int> lista = new List<int> {};
            for (int i = 0; i < liczby.Length; i++)
            {
                if (i>= lowIndex && i <= highIndex)
                {
                    lista.Add(liczby[i]);                
                }

            }
            if(lista.Count != 0)
            {
                Console.WriteLine($"Elementy w zakresie indeksów {lowIndex} i {highIndex}: {string.Join(", ", lista)}");
            }
            
        }
    }
}
