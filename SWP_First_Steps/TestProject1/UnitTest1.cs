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
 
    }
}