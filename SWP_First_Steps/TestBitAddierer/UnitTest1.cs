namespace TestBitAddierer
{
    public class Tests
    {
        Bitadder _bitAdder;
        [SetUp]
        public void Setup()
        {
            _bitAdder = new Bitadder();
        }

        [Test]
        [TestCase(true, true , false, true)]
        public void Halfadder_ShouldReturnCorrectResults(bool x, bool y, bool s, bool c)
        {
            Assert.That(_bitAdder.Halfadder(x, y), Is.EqualTo((s, c)));
        }

        [Test]
        [TestCase(true, true, true, true, true)]
        [TestCase(true, true, true, true, true)]
        public void Fulladder_Test(bool x, bool y, bool c, bool cout, bool s)
        {
            Assert.That(_bitAdder.Fulladder(x, y, c), Is.EqualTo((cout, s)));
        }

        [Test]
        [TestCase(false, false, false, false, false, false, false, true, false, false, false, true, false)]
        [TestCase(true, false, false, false, false, true, false, false, true, true, false, false, false)]
        [TestCase(false, true, false, true, true, false, true, false, true, true, true, true, false)]
        [TestCase(false, false, true, false, false, false, true, true, false, true, false, true, false)]
        [TestCase(false, true, false, false, false, true, false, false, true, false, false, false, false)]
        [TestCase(true, true, true, true, false, false, false, false, true, true, true, true, false)]
        public void FourBitAdder_ShouldReturnCorrectBitSum(bool a3, bool a2, bool a1, bool a0, bool b3, bool b2, bool b1, bool b0, bool sum3, bool sum2, bool sum1, bool sum0, bool carry3)
        {
            Assert.That(_bitAdder.FourBitadder(a3, a2, a1, a0, b3, b2, b1, b0), Is.EqualTo((sum3, sum2, sum1, sum0, carry3)));
        }

        [Test]
        [TestCase(3, 4, 7)]
        public void FourBitAdder_ShouldReturnCorrectIntSum(int x, int y, int result)
        {
            Assert.That(_bitAdder.funktionalFourBitadder(x, y), Is.EqualTo(result));
        }
    }
}