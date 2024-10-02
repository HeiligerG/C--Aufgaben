namespace TeilenDurchQuer
{
    public class Rechner
    {
        public static int BerechneQuersumme(int zahl)
        {
            int summe = 0;
            while (zahl > 0)
            {
                summe += zahl % 10;
                zahl /= 10;
            }

            return summe;
        }
    }
}