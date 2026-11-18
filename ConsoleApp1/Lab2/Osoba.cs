
namespace ConsoleApp1.Lab2
{
    internal class Osoba
    {
        private string imie = "";
        private string nazwisko = "";
        private int wiek;
        public string Imie { get
            {
                return imie;
            } set
            {
                if (value == null)
                {
                    throw new ArgumentException("Nazwa nie może być null.");
                }
                string poprawionaNazwa = value.Trim();
                if(poprawionaNazwa.Length <2)
                {
                    throw new ArgumentException("Imie musi mieć co najmniej 2 znaki");
                }
                imie = poprawionaNazwa;
            }
        }
        public string Nazwisko { get {
                return nazwisko;
            } set
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
        public int Wiek { get {
                return wiek;
            } set { 
                if(value <=0)
                {
                    throw new ArgumentOutOfRangeException("Wiek musi być większy od 0");
                }
                wiek = value;
            } }

        public Osoba(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko= nazwisko;
            Wiek = wiek;
        }
        public void WyswietlInformacje()
        {
            Console.WriteLine($"Dane osoby:");
            Console.WriteLine($"Imie: {imie}");
            Console.WriteLine($"Nazwisko: {nazwisko}");
            Console.WriteLine($"Wiek: {wiek}");
        }

    }
}
