using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korsunovulesandehinn
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Ülesanne 1.");//Määratud on viis suvalist täisarvu (massiivi elementi).
            //Tehke kindlaks, kas nende asukoht massiivis on järjestatud (st tõusvas või kahanevas) või järjestamata.
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            bool b;
            Console.WriteLine("Tellitud kasvavas järjekorras: {0}", b = a.SequenceEqual(a.OrderBy(x => x)));
            Console.WriteLine("Kahanevas järjekorras: {0}", b |= a.SequenceEqual(a.OrderByDescending(x => x)));
            Console.WriteLine("Pole tellitud: {0}", !b);

            Console.WriteLine("");

            Console.WriteLine("Ülesanne 2.");//Esitatakse N elemendi reaalarvude massiiv (kasutage juhuslike arvude generaatorit).
            //Määrake elementide arv, mille väärtused jäävad vahemikku -10 kuni +10.
            Console.Write("Sisesta suvaline number: ");
            var n = int.Parse(Console.ReadLine());
            var d = new int[n];
            var r = new Random();
            var count = 0;
            for (var i = 0; i < n; i++)
            {
                d[i] = r.Next(-10, 10);
                if (d[i] > -10 && d[i] < 10) count++;
            }
            Console.WriteLine("elementide arv {0}", count);

            Console.WriteLine("");

            Console.WriteLine("Ülesanne 3.");
            Console.ReadKey();
                                             //Antud: teave iga linna elaniku kohta sisaldab järgmisi elemente:
                                             //a) perekonnanimi, nimi, isanimi;
                                             //b) kodune aadress(tänav, maja);
                                             //c) sünniaeg.
                                             //Teave elaniku kohta on ühe suure massiivi element[].
                                             //Tuleb koostada antud aadressil elavate valijate nimekirjad tähestikulises järjekorras.
                                             //Märkus: vähemalt 18 - aastased inimesed saavad hääletada.

        }
    }
}
        /*struct infor
        {
            public string nimi; // имя
            public string adres; // адрес дома
            public int year; // год рождения
            infor[] B;
            B = new infor[5]; 

            B[0].nimi = "Beginning. Microsoft. Visual C# 2008.";
            B[0].adres = "Karli Watson, Christian Nagel, Jacob Hammer Pedersen, Jon D.Reid";
            B[0].year = 2008;

            B[1].nimi = "Pro C# 2010 and the .Net Planform. Fifth edition";
            B[1].adres = "Andrew Troelsen";
            B[1].year = 2010;*/