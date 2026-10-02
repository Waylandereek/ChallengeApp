using System;

class Program
{
    static void Main(string[] args)
    {
        string imie = "Ewa";
        bool kobieta = true;
        int wiek = 30;

        if (kobieta == true && wiek < 30)
        {
            Console.WriteLine("Kobieta poniżej 30 lat");
        }
        else if (imie == "Ewa" && wiek == 30)
        {
            Console.WriteLine("Ewa, lat 30");
        }
        else if (kobieta != false && wiek < 18)
        {
            Console.WriteLine("Niepełnoletni mężczyzna");
        }
    }
}