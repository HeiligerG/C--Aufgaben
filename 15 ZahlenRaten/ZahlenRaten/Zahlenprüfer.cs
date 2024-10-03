public class Zahlenprüfer
    {
        public int myrandom;

        public bool Checker(int zahl)
        {
            if (zahl == myrandom)
            {
                Console.WriteLine("Die Zahl stimmt, Gratulation!");
                return true;
            }
            else if (zahl > myrandom)
            {
                Console.WriteLine("Die Zahl ist kleiner!");
            }
            else
            {
                Console.WriteLine("Die Zahl ist grösser!");
            }
            return false;
        }
    }
