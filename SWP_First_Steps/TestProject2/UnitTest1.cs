using OOP_School;
namespace OOP_School_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestingObjektSchoolCreation()
        {
            var mySchool = new School("HTL Dornbirn", "HTL", "Dornbirn");
            Assert.AreEqual();
        }
    }
}