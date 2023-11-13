using CheckPointNr2;

namespace UnitTest.CheckPointNr2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Throw_attemptDescriptionSet_Exception()
        {
            //Arrange
            StarPlayer Attack1 = new("Lyle Taylor", 11, "kjempeflink til å score!");
            //Act
            TestDelegate Expected = () => Attack1.Description = "";
            //Assert
            Assert.Throws<Exception>(Expected);

        }
        [Test]
        public void Equals_compareTowInctances_returnsBool()
        {
            //Arrange
            StarPlayer Attack1 = new("Lyle Taylor", 11, "kjempeflink til å score!");
            //StarPlayer Attack2 = new("Lyle Taylorr", 101, "kjempeflink til å score!!");
            StarPlayer Attack2 = new("Lyle Taylor", 11, "kjempeflink til å score!");
            //Act
            bool expected = Attack1 == Attack2;
            //Assert
            //Assert.IsFalse(expected);
            Assert.IsTrue(expected);
        }
        

    }
}