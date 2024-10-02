using System;
using Tannenbaum;

class Program
{
    static void Main()
    {
        Zeichner myZeichner = new Zeichner();
        EingabeAbfrager myEingabeAbfrager = new EingabeAbfrager();
        
        Console.WriteLine("Tannenbaum-Zeichner");

        int stammBreite = myEingabeAbfrager.EingabeAbfragen("Breite des Stammes?");
        int stammHoehe = myEingabeAbfrager.EingabeAbfragen("Höhe des Stammes?");
        int kroneHoehe = myEingabeAbfrager.EingabeAbfragen("Höhe der Krone?");

        myZeichner.ZeichneTannenbaum(stammBreite, stammHoehe, kroneHoehe);
    }
}
