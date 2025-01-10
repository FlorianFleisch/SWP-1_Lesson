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
            Assert.AreEqual("HTL", mySchool.Schooltype);
        }

        [Test]
        public void TestingPersons()
        {
            var myPerson = new Person("Zebastan", (new DateTime(2000, 1, 12)));
            Assert.AreEqual(25, myPerson.Age);
        }
    }
}