using Objektorientiertes_Programmieren;
namespace TestProject1
{
    [TestFixture]
    public class TierheimTests
    {
        [SetUp]
        public void SetUp() { }

        [Test]
        public void AddAnimal_AddOneCatAndOneDog_ReturnsTwoAnimals()
        {
            var myTierheim = new Tierheim();
            myTierheim.Animals.Add(new Cat(new DateTime(2020, 02, 02), "Milly", "black"));
            myTierheim.Animals.Add(new Cat(new DateTime(2020, 02, 02), "Milly", "black"));

            myTierheim.Animals.Add(new Dog(new DateTime(2020, 02, 02), "Tommy", "red"));
            myTierheim.Animals.Add(new Dog(new DateTime(2020, 02, 02), "Tommy", "red"));

            Assert.IsTrue(myTierheim.AnzahlCats() == 2);
            Assert.IsTrue(myTierheim.AnzahlDogs() == 2);

        }
        [Test]
        public void AvgAge_AddTwoCatAndAddTwoDog_ReturnsAverageAgeFour()
        {
            var myTierheim = new Tierheim();
            myTierheim.Animals.Add(new Cat(new DateTime(2010, 02, 02), "Milly", "black"));
            myTierheim.Animals.Add(new Cat(new DateTime(2007, 02, 02), "Markus", "black"));

            myTierheim.Animals.Add(new Dog(new DateTime(2022, 02, 02), "Tommy", "red"));
            myTierheim.Animals.Add(new Dog(new DateTime(2021, 02, 02), "Tom", "red"));

            Assert.IsTrue(myTierheim.DurchschnittsalterTiere() == 9);
        }
    }
}