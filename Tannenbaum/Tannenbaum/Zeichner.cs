namespace Tannenbaum;

public class Zeichner
{
    public void ZeichneTannenbaum(int stammBreite, int stammHoehe, int kroneHoehe)
    {
        for (int i = 1; i <= kroneHoehe; i++)
        {
            int sterne = 2 * i - 1;
            int leerzeichen = kroneHoehe - i;
            Console.WriteLine(new string(' ', leerzeichen) + new string('*', sterne));
        }

        for (int i = 0; i < stammHoehe; i++)
        {
            int leerzeichen = (kroneHoehe - stammBreite / 2) - 1;
            Console.WriteLine(new string(' ', leerzeichen) + new string('*', stammBreite));
        }
    }
}