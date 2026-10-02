int[] grades = new int[365];
List<string> DayOfWeeks = new List<string>(7);
DayOfWeeks.Add("Poniedziałek");
DayOfWeeks.Add("Wtorek");
DayOfWeeks.Add("Środa");
DayOfWeeks.Add("Czwartek");
DayOfWeeks.Add("Piątek");
DayOfWeeks.Add("Sobota");
DayOfWeeks.Add("Niedziela");

foreach (var Day in DayOfWeeks)
{
    Console.WriteLine(Day);
}