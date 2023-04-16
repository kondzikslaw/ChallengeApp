namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void DifferenceOfStringValue()
        {
 
            string word1 = "Konrad";
            string word2 = "Kondrad";


            Assert.AreNotEqual(word1, word2);
        }

        [Test]
        public void TestOfFloatDifferentValue()
        {

            float number1 = 3.44f;
            float number2 = 7.52f;


            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void TestOfFloatEqualValue()
        {

            float number1 = 7.52f;
            float number2 = 7.52f;


            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {

            var employee1 = GetEmployee("Konrad", "Iksiński");
            var employee2 = GetEmployee("Konrad", "Iksiński");


            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}
