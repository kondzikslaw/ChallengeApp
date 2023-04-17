using ChallengeApp;

var employee = new Employee("Konrad", "Poszwiński");
employee.AddGrade("20000");
employee.AddGrade("Konrad");
employee.AddGrade(5);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

