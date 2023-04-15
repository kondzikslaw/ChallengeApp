using ChallengeApp;

Employee employee1 = new Employee("Andrzej", "Iksiński", 29);
Employee employee2 = new Employee("Maciej", "Igrekowski", 35);
Employee employee3 = new Employee("Marta", "Zetowska", 27);

employee1.AddScore(5);
employee1.AddScore(3);
employee1.AddScore(8);
employee1.AddScore(1);
employee1.AddScore(3);

employee2.AddScore(4);
employee2.AddScore(7);
employee2.AddScore(3);
employee2.AddScore(2);
employee2.AddScore(8);

employee3.AddScore(6);
employee3.AddScore(5);
employee3.AddScore(4);
employee3.AddScore(2);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxScore = -1;
Employee bestEmployee = null;

foreach (var employee in employees)
{
    if (employee.Score > maxScore)
    {
        maxScore = employee.Score;
        bestEmployee = employee;
    }
}
Console.WriteLine(bestEmployee.Name + ", " + bestEmployee.Surname + ", " + bestEmployee.Age + ", " + bestEmployee.Score);