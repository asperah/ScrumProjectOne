using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectOne {
    class Filter {

        static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };
        static string[] numbers2 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "eleven", "twelve", "thirteen", "fourteen" };

        public static void FOperationen() {



            Console.WriteLine("int[] numbers = {5,4,1,3,9,8,6,7,2,0,22,12,16,18,11,19,13}");
            Console.WriteLine();

            //Aufgabe 1.1:
            Console.WriteLine("1. Alle zahlen echt kleiner als 7: ");

            var numQuery =
            from number in numbers
            where (number < 7)
            select number;

            foreach (var number in numQuery)
            {
                Console.Write("{0}  ", number);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Aufgabe 1.2:
            Console.WriteLine("2.Alle geraden Zahlen: ");
            var numQuery2 =
            from number in numbers
            where (number % 2) == 0
            select number;

            foreach (var number in numQuery2)
            {
                Console.Write("{0}  ", number);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Aufgabe 1.3:
            Console.WriteLine("3.Alle einstelligen ungeraden Zahlen: ");
            var numQuery3 =
            from number in numbers
            where (number < 10) && (number % 2) != 0
            select number;

            foreach (var number in numQuery3)
            {
                Console.Write("{0}  ", number);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Aufgabe 1.4:
            Console.WriteLine("4.Alle geraden Zahlen ab dem 6. Element einschließlich: ");
            var numQuery4 =
            from number in numbers.Skip(5)
            where (number % 2) == 0
            select number;

            foreach (var number in numQuery4)
            {
                Console.Write("{0}  ", number);
            }
            Console.WriteLine();
            Console.WriteLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Aufgabe 2.1:

            Console.WriteLine("string[] numbers2 = {'zero','one','two','three','four','five','six','seven','eight','nine','eleven','twelve','thirteen','fourteen'}" );
            Console.WriteLine();

            Console.WriteLine("2.1 Alle Zahlen die drei Zeichen lang sind: ");
            
            var letterQuery1 =
            from letters in numbers2
            where letters.Length == 3
            select letters;

            foreach (var letters in letterQuery1)
            {
                Console.Write("{0}  ", letters);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Aufgabe 2.2:

            Console.WriteLine("2.2 Alle Zahlen die ein o enthalten: ");

            var letterQuery2 =
            from letters in numbers2
            where letters.Contains('o')
            select letters;

            foreach (var letters in letterQuery2)
            {
                Console.Write("{0}  ", letters);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Aufgabe 2.3:

            Console.WriteLine("2.3 Alle Zahlen die auf teen enden: ");

            var letterQuery3 =
            from letters in numbers2
            where letters.EndsWith("teen")
            select letters;

            foreach (var letters in letterQuery3)
            {
                Console.Write("{0}  ", letters);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Aufgabe 2.4:

            Console.WriteLine("2.4 Alle Zahlen die auf teen enden: ");

            var letterQuery4 =
            from letters in numbers2
            where letters.EndsWith("teen")
            select letters.ToUpper();

            foreach (var letters in letterQuery4)
            {
                Console.Write("{0}  ", letters);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Aufgabe 2.5:

            Console.WriteLine("2.5 Alle Zahlen die auf teen enden: ");

            var letterQuery5 =
            from letters in numbers2
            where letters.Contains("four")
            select letters;

            foreach (var letters in letterQuery5)
            {
                Console.Write("{0}  ", letters);
            }
            Console.WriteLine();
            Console.WriteLine();





        }


    }
}
