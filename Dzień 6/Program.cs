using System;
using System.Collections.Generic;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public List<int> Scores { get; set; } = new List<int>();
}

class Program
{
    static void Main()
    {
        var emp1 = new Employee();
        emp1.FirstName = "Adam";
        emp1.LastName = "Kowalski";
        emp1.Age = 25;
        emp1.Scores.Add(8);
        emp1.Scores.Add(7);
        emp1.Scores.Add(10);
        emp1.Scores.Add(6);
        emp1.Scores.Add(9);

        var emp2 = new Employee();
        emp2.FirstName = "Jan";
        emp2.LastName = "Abażur";
        emp2.Age = 30;
        emp2.Scores.Add(6);
        emp2.Scores.Add(5);
        emp2.Scores.Add(8);
        emp2.Scores.Add(7);
        emp2.Scores.Add(6);

        var emp3 = new Employee();
        emp3.FirstName = "Damian";
        emp3.LastName = "Miotełka";
        emp3.Age = 28;
        emp3.Scores.Add(9);
        emp3.Scores.Add(10);
        emp3.Scores.Add(9);
        emp3.Scores.Add(9);
        emp3.Scores.Add(10);

        Employee bestEmployee = emp1;
        int bestScore = 0;

        foreach (int score in emp1.Scores)
        {
            bestScore += score;
        }

        int emp2Score = 0;

        foreach (int score in emp2.Scores)
        {
            emp2Score += score;
        }

        if (emp2Score > bestScore)
        {
            bestEmployee = emp2;
            bestScore = emp2Score;
        }

        int emp3Score = 0;

        foreach (int score in emp3.Scores)
        {
            emp3Score += score;
        }

        if (emp3Score > bestScore)
        {
            bestEmployee = emp3;
            bestScore = emp3Score;
        }

        Console.WriteLine("Najwyższy wynik ma:");
        Console.WriteLine(bestEmployee.FirstName + " " + bestEmployee.LastName);
        Console.WriteLine("Wiek: " + bestEmployee.Age);
        Console.WriteLine("Wynik: " + bestScore);
    }
}