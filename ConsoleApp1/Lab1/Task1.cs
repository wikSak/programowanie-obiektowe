namespace ConsoleApp1.Lab1
{
    internal class Task1
    {
        //metoda do obliczania delty
        double ObliczDelte(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            return delta;
        }

        void ObliczPierwiastki(double a, double b, double delta)
        {
            if (delta > 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                double x2 = (-b + Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine($"Równanie posiada dwa pierwiastki x1 = {x1:F3} i x2= {x2:F3}");
            } else if (delta == 0)
            {
                double x0 = -b / (2 * a);
                Console.WriteLine($"Równanie posiada jeden pierwiastek x0 = {x0} ");
            } else
            {
                Console.WriteLine($"Brak rozwiązania w zbiorze liczb rzeczywistych");
            }
        }
        public void Run()
        {
            Console.WriteLine("Podaj wspołczynnik a = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspołczynnik b = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspołczynnik c = ");
            double c = double.Parse(Console.ReadLine());

            if(a == 0)
            {
                Console.WriteLine("To nie jest równanie kwadratowe");
                return;
            }
            double delta = ObliczDelte(a, b, c);
            //F2 MIEJSCA PO PRZECINKU
            Console.WriteLine($"Delta = {delta:F2}");
            ObliczPierwiastki(a,b, delta);
        }
    }
}
