static void Main()
{

}
public class Bitadder
{
        public (bool, bool, bool) Fulladder (bool x, bool y, bool c)
        {
        bool Hafadder1 = (!x && y) || (x && !y);
        bool carryHalfadder1 = !x && y;

        bool Hafadder2 = (!y && c) || (y && !c);
        bool carryHalfadder2 = !y && c;
    }
}
