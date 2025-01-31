public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(true, false, true, false)]
    [TestCase(false, false, false, false)]
    [TestCase(false, true, true, false)]
    [TestCase(true, true, false, true)]
    public void HalfAdding_DifferentInputs_Returns_True_Value(bool x, bool y, bool s, bool c)
    {
        var myAdder = new FourBitAdd(); 
        var res = myAdder.HalfAdding(true, true);
        Assert.That(res=(s, c));
    }
}