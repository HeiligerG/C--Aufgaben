namespace Schaltjahr;

public class SchaltjahrPrüfer
{
    public bool IstSchaltjahr(int jahr)
    {
        switch (jahr)
        {
            case var n when n % 400 == 0:
                return true;
            case var n when n % 100 == 0:
                return false;
            case var n when n % 4 == 0:
                return true;
            default:
                return false;
        }
    }
}