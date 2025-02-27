using System;
using System.Reflection;
using System.Security.Cryptography;

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

    public (bool, bool, bool, bool) ConverterIntToBit(int x)
    {
        bool[] bit = new bool[4];

        for (int i = 3; i >= 0; i--) 
        {
            bit[i] = (x % 2 == 1);
            x /= 2;
        }

        return (bit[0], bit[1], bit[2], bit[3]);
    }

    public (bool, bool, bool, bool, bool, bool, bool, bool) Convert2IntsToBits(int x, int y)
    {
        (bool a3, bool a2, bool a1, bool a0) = ConverterIntToBit(x);
        (bool b3, bool b2, bool b1, bool b0) = ConverterIntToBit(y);
       
        return (a3, a2, a1, a0, b3, b2, b1, b0);
    }


    public int ConverterBitToInt(bool sum3, bool sum2, bool sum1, bool sum0)
    {
       int decimal1 = 0;
        if (sum3) { decimal1 += 8; }
        if (sum2) { decimal1 += 4; }
        if (sum1) { decimal1 += 2; }
        if (sum0) { decimal1 += 1; }

        return decimal1;
    }

    public (bool, bool, bool, bool, bool) FourBitadder(bool a3, bool a2, bool a1, bool a0, bool b3, bool b2, bool b1, bool b0)
    {
        (bool sum0, bool carry0) = Halfadder(a0, b0);
        (bool sum1, bool carry1) = Fulladder(a1, b1, carry0);
        (bool sum2, bool carry2) = Fulladder(a2, b2, carry1);
        (bool sum3, bool carry3) = Fulladder(a3, b3, carry2);

        return (sum3, sum2, sum1, sum0, carry3);
    }

    public int funktionalFourBitadder(int x, int y)
    {
        (bool a3, bool a2, bool a1, bool a0, bool b3, bool b2, bool b1, bool b0) = Convert2IntsToBits(x, y);

        (bool sum3, bool sum2, bool sum1, bool sum0, bool carry3) = FourBitadder(a3, a2, a1, a0, b3, b2, b1, b0);


        return ConverterBitToInt(sum3, sum2, sum1, sum0);
    }
}
