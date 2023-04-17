namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenAddGradesWithDiffrentValues_ShouldShowAverageGrade()
        {

            var employee = new Employee("Konrad", "Iksiński");

            employee.AddGrade(45);
            employee.AddGrade(26);
            employee.AddGrade(57);
            employee.AddGrade(35);
            employee.AddGrade(62);
            employee.AddGrade(11);
            employee.AddGrade(94);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(Math.Round(47.14f), Math.Round(statistic.Average));
        }

        [Test]
        public void WhenAddGradesWithDiffrentValues_ShouldShowAverageLetter()
        {

            var employee = new Employee("Konrad", "Iksiński");

            employee.AddGrade(45);
            employee.AddGrade(26);
            employee.AddGrade(57);
            employee.AddGrade(35);
            employee.AddGrade(62);
            employee.AddGrade(11);
            employee.AddGrade(94);

            var statistic = employee.GetStatistics();

            Assert.AreEqual('C', statistic.AverageLetter);
        }

        [Test]
        public void WhenAddGradesWithDiffrentValues_ShouldShowMax()
        {

            var employee = new Employee("Konrad", "Iksiński");

            employee.AddGrade(45);
            employee.AddGrade(26);
            employee.AddGrade(57);
            employee.AddGrade(35);
            employee.AddGrade(62);
            employee.AddGrade(11);
            employee.AddGrade(94);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(94, statistic.Max);
        }

        [Test]
        public void WhenAddGradesWithDiffrentValues_ShouldShowMin()
        {

            var employee = new Employee("Konrad", "Iksiński");

            employee.AddGrade(45);
            employee.AddGrade(26);
            employee.AddGrade(57);
            employee.AddGrade(35);
            employee.AddGrade(62);
            employee.AddGrade(11);
            employee.AddGrade(94);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(11, statistic.Min);
        }
    }
}
