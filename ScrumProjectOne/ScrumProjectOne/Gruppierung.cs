using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectOne
{
    class Gruppierung
    {
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
                    Console.WriteLine("    "+zahl);
                }

            }

        }

        // Gruppieren der Worte nach der Länge 

        public static void GruppierenNachLänge()
        {
            var nummer = numbers.GroupBy(x=>x.Length);

            foreach (var item in nummer)
            {
                Console.WriteLine(item.Key);

                foreach (var zahl in item)
                {
                    Console.WriteLine("    "+zahl);
                }
            }

        }

        // Gruppieren nach Länge und Anfangsbuchstabe 
        public static void GruppierenNachLängeUndAnfangsbuchstabe()
        {
            



         //   var nummer = numbers.GroupBy(x=>x.First(),x => x.Length ) ;
            var nummer = numbers.GroupBy(x=>new { x.Length, buchstabe = x.Substring(0, 1) }) ;

            foreach (var item in nummer)
            {
                Console.WriteLine(item.Key.buchstabe);

                foreach (var zahl in item)
                {
                    Console.WriteLine(zahl);
                }
            }



        }
    }
}
