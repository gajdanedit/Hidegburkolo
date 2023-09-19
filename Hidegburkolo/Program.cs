using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hidegburkolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérlek add meg a szoba szélességét méterben!");
            double szelesseg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kérlek add meg a szoba hosszúságát méterben!");
            double hosszusag = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kérlek add meg a szoba magasságát méterben!");
            double magassag = Convert.ToDouble(Console.ReadLine());

            double terulet = 2 * (szelesseg + hosszusag) * magassag + szelesseg * hosszusag;

            double teruletPluszTizSzazalek = terulet * 1.10;
            double csomagFelulet = 1.44;
            double szuksegeCsomagok = Math.Ceiling(teruletPluszTizSzazalek / csomagFelulet);
            Console.WriteLine($"Szükséges csomagok száma: {szuksegeCsomagok} csomag");
            Console.ReadLine();

        }

    }
}
