namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void TestOfMaxStatisticValue()
        {

            var employee = new Employee("Konrad", "Iksiński");

            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(7);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(7, statistic.Max);
        }

        [Test]
        public void TestOfMinStatisticValue()
        {

            var employee = new Employee("Konrad", "Iksiński");

            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(7);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(4, statistic.Min);
        }

        [Test]
        public void TestOfAverageStatisticValue()
        {

            var employee = new Employee("Konrad", "Iksiński");

            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(8);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(6, statistic.Average);
        }
    }
}
