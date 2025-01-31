namespace TestBitAddierer
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(true, true , false, true)]
        public void Halfadder_ShouldReturnCorrectResults(bool x, bool y, bool s, bool c)
        {
            var bitadder = new Bitadder();

            Assert.That(bitadder.Halfadder(x, y), Is.EqualTo((s, c)));
        }

        [Test]
        [TestCase(true, true, true, true, true)]
        public void Fulladder_Test(bool x, bool y, bool c, bool cout, bool s)
        {
            var bitadder = new Bitadder();

            Assert.That(bitadder.Fulladder(x, y, c), Is.EqualTo((cout, s)));
        }
    }
}