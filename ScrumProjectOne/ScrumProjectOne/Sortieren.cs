using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ScrumProjectOne
{


    public delegate void SortierenDelegate();

      

    class Sortieren
    {

        static int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };
        static string[] numbers2 = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };

        // Array Aufsteigend ausgeben
        public static void AufsteigendSortierenVonIntArray()
        {
            var nummer1 = numbers.OrderBy(x => x);

            foreach ( var item in nummer1)
            {
                Console.Write(item+" ");
            }


        }
        // Array Absteigend ausgeben 
        public static void AbsteigendSortirenVonIntArray()
        {
            var nummer1 = numbers.OrderByDescending(x => x);
            foreach (var item in nummer1)
            {
                Console.Write(item+ " ");
            }

        }
        // Gerade zahlen aufsteigend ausgeben 
        public static void GeradeZahlenSortiertAufsteigendAusgeben()
        {
            var nummer1 = numbers.Where(x => x % 2 == 0).OrderBy(x=> x);
            foreach (var item in nummer1)
            {
                Console.Write(item+" ");
            }

        }
        //Länge der Worte aufsteigend ausgeben 
        public static void LängeDerWorteAufsteigen()
        {
            var nummer1 = numbers2.OrderBy(x => x.Length);
            foreach (var item in nummer1)
            {
                Console.WriteLine(item+" ");
            }

        } 
        //Länge der Worte aufsteigend und bei gleicher Länge Alphabetisch absteigend sortiert
        public static void LängeDerWorteAufsteigendUndAlphabetisch()
        {
            var nummer1 = numbers2.Where(x => x.Length == x.Length).OrderByDescending(x => x).OrderBy(x => x.Length);

            foreach (var item in nummer1)
            {
                Console.Write(item+ " ");
            }

        }
        // Reihenfolge im Array drehen 
        public static void ReihenfolgeImArrayDrehen()
        {
            var nummer1 = numbers2.Reverse();

            foreach (var item in nummer1)
            {
                Console.Write(item+" ");
            }


        }
        // Erstellen der Directory Info Objekt

        static DirectoryInfo info = new DirectoryInfo(@"C:\Users\Administrator\ScrumProjectOne");


        //Inhalt absteigend nach namen sortiert 
        public static void InhaltAbsteigendNachNamen()
        {
            var nummer1 = info.GetFiles().OrderBy(x=>x.Name);


            foreach (var item in nummer1)
            {
                Console.WriteLine(item);
            }
        }
        // Inhalt nach Größe Sortieren
        public static void InhaltNachGrößeSortiert()
        {
            var nummer1 = info.GetFiles().OrderByDescending(x => x.Length);

            foreach (var item in nummer1)
            {
                Console.WriteLine(item);
            }
        }
        // Dateien nach Letzten Zutriit Sortieren
        public static void DateienAuflistenNachDatum()
        {
            var nummer1 = info.GetFiles().OrderByDescending(x => x.LastAccessTime);

            foreach (var item in nummer1)
            {
                Console.WriteLine(item);
            }

        }


        public static void AuswahlVerfahren()
        {
            Console.Clear();
            int auswahl; 
            bool filtermenu = true;
            while(filtermenu){
                Console.WriteLine(  "=============================================\n" +
                                    "+               Sortieren                   +\n" +
                                    "=============================================");
            Console.WriteLine("Welches Sortier Verfahren möchten sie anwenden ?\n" +
                              "[1] Zahlen Array aufsteigend Sortiert ausgeben \n" +
                              "[2] Zahlen array absteigend Sortieren\n" +
                              "[3] Zahlen Array sortiert ausgeben nur gerade Zahlen\n" +
                              "[4] Wörter Array Nach Länge der Worte aufsteigen ausgeben\n" +
                              "[5] Wörter Array Nach Länge der Worte aufsteigen Sortiert ausgeben und bei gleicher Länge alphabetisch absteigensortiert\n" +
                              "[6] Wörter Array in umgekehrter Reheinfolge ausgeben\n" +
                              "[7] Liste der Dateien Absteigend nach Namen sortiert\n" +
                              "[8] Liste nach Größe aufsteigen sortieren\n" +
                              "[9] Liste nach Datum des Letzten zugriffs Sortieren, Jüngste zuerst\n"+
                              "[0] Zurück zum Hauptmenu. \n" 
                              );

            auswahl = Convert.ToInt32(Console.ReadLine());

            switch (auswahl)
            {
                                    case 0:
                        filtermenu = false;
                        break;
                case 1:
                    {
                        AufsteigendSortierenVonIntArray();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case 2:
                    {

                        AbsteigendSortirenVonIntArray();
                        Console.ReadLine();
                        Console.Clear();
                        break; 
                    }
                case 3:
                    {
                        GeradeZahlenSortiertAufsteigendAusgeben();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    }
                case 4:
                    {
                        LängeDerWorteAufsteigen();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    }
                case 5:
                    {

                        LängeDerWorteAufsteigendUndAlphabetisch();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case 6:
                    {
                        ReihenfolgeImArrayDrehen();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case 7:
                    {
                        InhaltAbsteigendNachNamen();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    }
                case 8:
                    {
                        InhaltNachGrößeSortiert();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case 9:
                    {
                        DateienAuflistenNachDatum();
                        Console.ReadLine();
                        Console.Clear();
                        break; 

                    }



            }
                }
        }

    }
}
