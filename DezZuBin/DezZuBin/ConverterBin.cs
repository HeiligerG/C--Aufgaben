namespace DezZuBin;

public class ConverterBin
{
    public string ConvertToBinary(int n)
    {
        if (n == 0)
            return "0";

        string bin = "";
        while (n > 0)
        {
            int rest = n % 2;
            bin = rest + bin;
            n = n / 2;
        }
        return bin;
    }
}