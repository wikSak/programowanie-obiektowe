namespace ConsoleApp1.Lab2
{
    internal class BankAccount
    {
        private decimal saldo;
        private string wlasciciel;
        public decimal Saldo { get {
                return saldo;
            } private set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException ("Saldo nie może być ujemne.");
                }
                saldo = value;
            } }
        public string Wlasciciel { get { return wlasciciel; } set {
                if (value == null || value.Length == 0 || value.Trim().Length == 0) {
                    throw new ArgumentException("Niepoprawna nazwa");
                }
                string poprawionaNazwa = value.Trim();
                wlasciciel = poprawionaNazwa;
            } }
        public BankAccount(string wlasciciel, decimal saldoPoczatkowe)
        {
            Saldo = saldoPoczatkowe;
            Wlasciciel= wlasciciel;
        }

        public void Wplata(decimal kwota) {
            if (kwota <= 0)
            {
                throw new ArgumentOutOfRangeException("Wplata musi być większa od 0.");
            }
            saldo += kwota;
        }
        public void Wyplata(decimal kwota)
        {
            if (kwota <= 0)
            {
                throw new ArgumentOutOfRangeException("Wyplata musi być większa od 0.");
            }
            if(saldo >= kwota)
            {
                saldo -= kwota;
            } else
            {
                throw new InvalidOperationException("Niewystarczająca ilość środków.");
            }
            
        }
    }

}
