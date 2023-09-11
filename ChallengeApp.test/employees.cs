namespace ChallengeApp.test
{
    public class Test
    {

        [Test]
        public void WhenUserCollectScores_ShouldCorectReasult()
        {
            //arrange
            var employee = new Employee("Adam", "Kowal", 25, new int[] { -8, -9, 5, 7, 4 });
           
            //act
            
            var totalRatings = employee.CalculateTotalRatings();

            //Assert
            Assert.AreEqual(-1, totalRatings);
        }
    }
}