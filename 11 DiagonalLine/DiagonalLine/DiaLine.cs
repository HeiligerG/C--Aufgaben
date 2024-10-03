namespace DiagonalLine;

public class DiaLine
{
    public static void Diagonale(int länge)
    {
        for (int i = 0; i < länge; i++)
        {
            for (int j = 0; j < länge; j++)
            {
                if (i == j)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}