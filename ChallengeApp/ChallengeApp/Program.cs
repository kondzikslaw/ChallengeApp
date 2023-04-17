using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee("Konrad", "Poszwiński");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
