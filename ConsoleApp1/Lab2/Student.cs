namespace ConsoleApp1.Lab2
{
    internal class Student
    {
        private string imie = "";
        private string nazwisko = "";
        private int[] oceny = new int[0];
        public string Imie
        {
            get
            {
                return imie;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Nazwa nie może być null.");
                }
                string poprawionaNazwa = value.Trim();
                if (poprawionaNazwa.Length < 2)
                {
                    throw new ArgumentException("Imie musi mieć co najmniej 2 znaki");
                }
                imie = poprawionaNazwa;
            }
        }
        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Nazwa nie może być null.");
                }
                string poprawionaNazwa = value.Trim();
                if (poprawionaNazwa.Length < 2)
                {
                    throw new ArgumentException("Nazwisko musi mieć co najmniej 2 znaki");
                }
                nazwisko = poprawionaNazwa;
            }
        }

        public double SredniaOcen
        {
            get
            {
                if (oceny.Length == 0)
                {
                    return 0;
                }
                int suma = 0;
                for (int i = 0; i < oceny.Length; i++)
                {
                    suma += oceny[i];
                }
                double srednia = (double)suma/ oceny.Length;
                if (srednia < 0) { 
                    srednia = Math.Abs(srednia);
                }
                return srednia;
            }
        }
        public int LiczbaOcen
        {
            get
            {
                int dlugosc = oceny.Length;
                return dlugosc;
            }
        }
        public Student(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;

        }

        public void DodajOcene(int ocena)
        {
            if (ocena < 2 || ocena > 5)
            {
                throw new ArgumentOutOfRangeException("Ocena jest poza zakresem 2-5");
            }

            Array.Resize(ref oceny, oceny.Length + 1);
            oceny[oceny.Length -1] = ocena;
            //Console.WriteLine(string.Join(", ", oceny));
        }
    }
}
