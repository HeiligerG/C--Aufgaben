namespace Schaltjahr;

public class SchaltjahrPrüfer
{
    public bool IstSchaltjahr(int jahr)
    {
        switch (jahr)
        {
            case int n when n % 400 == 0:
                return true;
            case int n when n % 100 == 0:
                return false;
            case int n when n % 4 == 0:
                return true;
            default:
                return false;
        }
    }
}