static void Main()
{

}
public class FourBitAdd
{
    public (bool s, bool c) HalfAdding(bool x, bool y)
    {
        var result = !x && y;
        var res2 = x && !y;
        var s = x || y;
        var c = x && y;
        return (s, c);
    }
}
