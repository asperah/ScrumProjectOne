using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectOne
{
    public delegate void Gruppierungsdelegate();
    class Gruppierung
    {
        public static Gruppierungsdelegate auswahlGruppierung = new Gruppierungsdelegate(Gruppierung.Auswahlverfahren);

        static string[] numbers = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };

        // Gruppieren der Worte nach dem Anfangsbuchstaben
        public static void GruppierenNachAnfangsBuchstaben()
        {

            var nummer = numbers.GroupBy(x => x.First());
            foreach (var item in nummer)
            {
                Console.WriteLine(item.Key);
                foreach (var zahl in item)
                {
                    Console.WriteLine("    " + zahl);
                }

            }

        }

        // Gruppieren der Worte nach der Länge 

        public static void GruppierenNachLänge()
        {
            var nummer = numbers.GroupBy(x => x.Length);

            foreach (var item in nummer)
            {
                Console.WriteLine(item.Key);

                foreach (var zahl in item)
                {
                    Console.WriteLine("    " + zahl);
                }
            }

        }




        // Gruppieren nach Länge und Anfangsbuchstabe 
        public static void GruppierenNachLängeUndAnfangsbuchstabe()
        {


            var nummer = numbers.GroupBy(x => new { x.Length, buchstabe = x.Substring(0, 1) });

            foreach (var item in nummer)
            {
                Console.WriteLine(item.Key.buchstabe);

                foreach (var zahl in item)
                {
                    Console.WriteLine(zahl);
                }
            }

        }

        public static void Auswahlverfahren()
        {

            int auswahl;

            Console.WriteLine("Welches Gruppier Verfahren möchten sie anwenden ?\n" +
                              "[1] Gruppieren der Worte nach dem Anfangsbuchstaben \n" +
                              "[2] Gruppieren der Worte nach der Länge\n" +
                              "[3] Gruppieren nach Länge und Anfangsbuchstabe\n");


            auswahl = Convert.ToInt32(Console.ReadLine());


            switch (auswahl)
            {
                case 1:
                    {
                        GruppierenNachAnfangsBuchstaben();
                        break;
                    }
                case 2:
                    {

                        GruppierenNachLänge();
                        break;
                    }
                case 3:
                    {
                        GruppierenNachAnfangsBuchstaben();
                        break;

                    }
            }
        }
    }
}