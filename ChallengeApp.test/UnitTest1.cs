namespace ChallengeApp.test
{
    public class Tests
    {
      //  [SetUp]
       // public void Setup()
      //  {
      //  }

        [Test]
        public void Test1()
        {
            //Arrange
            int age1 = 10;
            int age2 = 3;

            //act
            int result = age1 + age2;

            //assert
            Assert.AreEqual(12, result);
        }
    }
}