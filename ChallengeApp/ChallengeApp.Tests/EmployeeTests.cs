namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeGetPoints_ShouldReturnCorrectResult()
        {
            //arrange
            var employee = new Employee("Konrad", "Iksiński", 33);
            employee.AddScore(4);
            employee.AddScore(8);
            employee.AddScore(-3);
            employee.AddScore(5);
            employee.AddScore(-6);

            //act
            var result = employee.Score;

            //assert
            Assert.AreEqual(8, result);
        }
    }
}