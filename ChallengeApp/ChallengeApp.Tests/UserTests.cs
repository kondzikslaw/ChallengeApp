namespace ChallengeApp.Tests
{
    public class UserTests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldReturnCorrectResult()
        {
            //arrange
            var user = new User("Konrad", "asdfa123");
            user.AddScore(4);
            user.AddScore(8);

            //act
            var result = user.Score;
            
            //assert
            Assert.AreEqual(12, result);
        }
    }
}