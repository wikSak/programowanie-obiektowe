using ConsoleApp1.Lab1;
using ConsoleApp1.Lab2;
Task1 task1 = new Task1();
//task1.Run();

Task2 task2 = new Task2();

//task2.RunTask2();

Task3 task3 = new Task3();
//task3.ShowNumbers();
Task4 task4 = new Task4();
//task4.ShowNumbers();

Task5 task5 = new Task5();
//task5.Main();


//---------------------------LAB2-----------------------------------
//Lab2 zad.1
//Licz licz1 = new Licz(10);
//Licz licz2 = new Licz(20);

////licz1.value = 10;
////licz2.value = 20;
//licz1.Dodaj(5);
//licz2.Odejmij(3);

////Console.WriteLine($"Wartość pierwszego elementu: {licz1.value}, wartość drugiego elementu: {licz2.value}");

//licz1.WyswietlStan();
//licz2.WyswietlStan();

//licz1.Dodaj(-2);
//licz2.Odejmij(-3);
//licz1.WyswietlStan();
//licz2.WyswietlStan();
//-------------------------------------------------------------------
//Lab2 zad.2
////Osoba osoba = new Osoba(" Anna ", "Kowalska", 20);
////Osoba osoba = new Osoba(null, "Kowalska", 20); 
//Osoba osoba = new Osoba("Anna", "Kowalska", 20);

//try
//{
//    osoba.Imie = " Anna ";
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    osoba.Imie = "A";
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    osoba.Nazwisko = "      ";
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    osoba.Nazwisko = null ;
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    osoba.Wiek = 0;
//}
//catch (ArgumentOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    osoba.Wiek = -5;
//}
//catch (ArgumentOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//osoba.WyswietlInformacje();
//Osoba osoba2 = new Osoba("A", "K", 0);
//-------------------------------------------------------------------
//Lab2 zad.3
//BankAccount konto = new BankAccount("Jan Kowalski", 1000m);
//konto.Wplata(500m);
//konto.Wyplata(200m);
//Console.WriteLine(konto.Saldo); // wartość: 1300

//try
//{
//    konto.Wplata(0);
//} catch (ArgumentOutOfRangeException ex) {  Console.WriteLine(ex.Message); }

//try
//{
//    konto.Wplata(-100m);
//}
//catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }

//try
//{
//    konto.Wyplata(2000m);
//}
//catch (InvalidOperationException ex) { Console.WriteLine(ex.Message); }

//try
//{
//    konto.Wyplata(1300m);
//}
//catch (InvalidOperationException ex) { Console.WriteLine(ex.Message); }

//Console.WriteLine(konto.Saldo); // wartość: 0

//BankAccount konto1 = new BankAccount("Jan Kowalski", -1000m);

//-------------------------------------------------------------------
//Lab2 zad.4

//Sumator sumator = new Sumator([1, 2]);
//Console.WriteLine(sumator.Suma());
//Console.WriteLine(sumator.SumaPodzielnychPrzez2());
//Console.WriteLine(sumator.IleElementow());
//sumator.WypiszWszystkie();
//sumator.WypiszZakres(2, 1);

//Sumator sumator = new Sumator([1, 2,3,4,-6]);
//Console.WriteLine(sumator.Suma());
//Console.WriteLine(sumator.SumaPodzielnychPrzez2());
//Console.WriteLine(sumator.IleElementow());
//sumator.WypiszZakres(1, 3);
//sumator.WypiszZakres(-3, 1);
//sumator.WypiszZakres(3, 20);
//sumator.WypiszZakres(8, 12);
//sumator.WypiszZakres(3, 1);

//Sumator sumator = new Sumator([]);
//Console.WriteLine(sumator.Suma());
//Console.WriteLine(sumator.SumaPodzielnychPrzez2());
//Console.WriteLine(sumator.IleElementow());
//sumator.WypiszZakres(1, 3);
//sumator.WypiszZakres(-3, 1);
//sumator.WypiszZakres(3, 20);
//sumator.WypiszZakres(8, 12);
//sumator.WypiszZakres(3, 1);

//int[] zrodlo = { 1, 2, 3 };
//Sumator sumator = new Sumator(zrodlo);
//zrodlo[0] = 100;
//Console.WriteLine(sumator.Suma());

//-------------------------------------------------------------------
//Lab2 zad.5

Student student = new Student("Wika", "Sak");
Console.WriteLine($"Średnia: {student.SredniaOcen:F1}");
Console.WriteLine($"Liczba ocen: {student.LiczbaOcen}");

student.DodajOcene(3);
Console.WriteLine($"Średnia: {student.SredniaOcen:F1}");
Console.WriteLine($"Liczba ocen: {student.LiczbaOcen}");

student.DodajOcene(4);
Console.WriteLine($"Średnia: {student.SredniaOcen:F1}");
Console.WriteLine($"Liczba ocen: {student.LiczbaOcen}");

try
{
    student.DodajOcene(6);
} catch (ArgumentOutOfRangeException ex) { 
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"Średnia: {student.SredniaOcen:F1}");
Console.WriteLine($"Liczba ocen: {student.LiczbaOcen}");

Student student2 = new Student("Jakub", "Lizak");
Console.WriteLine($"Średnia student2: {student2.SredniaOcen:F1}");
Console.WriteLine($"Liczba ocen student2: {student2.LiczbaOcen}");

student2.DodajOcene(5);
Console.WriteLine($"Średnia student2: {student2.SredniaOcen:F1}");
Console.WriteLine($"Liczba ocen student2: {student2.LiczbaOcen}");

student2.DodajOcene(3);
Console.WriteLine($"Średnia student2: {student2.SredniaOcen:F1}");
Console.WriteLine($"Liczba ocen student2: {student2.LiczbaOcen}");

Console.WriteLine($"Średnia student1: {student.SredniaOcen:F1}");
Console.WriteLine($"Liczba ocen student1: {student.LiczbaOcen}");