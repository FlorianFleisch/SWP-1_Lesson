using System;

static void main() { }
public class Bitadder
{

    public (bool, bool) Halfadder(bool x, bool y)
    {
        return (((!x && y) || (x && !y)), (x && y));
    }

    public (bool, bool) Fulladder(bool x, bool y, bool c)
    {
        (bool s1, bool carry1) = Halfadder(x, y);
        (bool s2, bool carry2) = Halfadder(s1, c);
        return (s2, carry1 || carry2);
    }

    public int UmwandlerDezimalInBinär(int x, int y)
    {
        string binär = "";

        while (x > 0)
        {
            binär = (x % 2) + binär;  
            x /= 2;  
        }

        return binär;

    }
    public int FourBitadder(int x, int y)
    {
        (bool a0, bool b0) = Halfadder(x, y);
        (bool a1, bool b1) = Fulladder(x, y, b0);
        (bool a2, bool b2) = Fulladder(b2 || a0, a1, b1);
        return 0;
    }
}