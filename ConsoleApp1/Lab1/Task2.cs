namespace ConsoleApp1.Lab1
{
    internal class Task2
    {
        double[] array = new double[10];
        //Wpisanie elementów
        void InputArray(double[] array)
        {
            Console.WriteLine("Podaj elementy tablicy");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Podaj {i + 1} element tablicy: ");
                array[i] = double.Parse(Console.ReadLine());
            }
        }
        //suma elementów
        double SumArray(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        double IloczynArray(double[] array)
        {
            double iloczyn = 1;
            for (int i = 0; i < array.Length; i++)
            {
                iloczyn *= array[i];
            }
            return iloczyn;
        }
        double SredniaArray(double[] array)
        {
            double sum = SumArray(array);
            return sum / array.Length;
        }

        double MinArray(double[] array)
        {
            double min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if(min > array[i])
                {
                    min = array[i];
                }
            }
            return min;

        }
        double MaxArray(double[] array)
        {
            double max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        public void RunTask2()
        {
            double[] array = new double[10];
            InputArray(array);
            double sum = SumArray(array);
            double iloczyn = IloczynArray(array);
            double srednia = SredniaArray(array);
            double min = MinArray(array);
            double max = MaxArray(array);

            Console.WriteLine("\nWyniki obliczeń: ");
            Console.WriteLine($"Suma elementów tablicy: {sum}");
            Console.WriteLine($"Iloczyn elementów tablicy: {iloczyn}");
            Console.WriteLine($"Średnia elementów tablicy: {srednia:F2}");
            Console.WriteLine($"Minimum elementów tablicy: {min:F2}");
            Console.WriteLine($"Maximum elementów tablicy: {max:F2}");
        }
    }
}
