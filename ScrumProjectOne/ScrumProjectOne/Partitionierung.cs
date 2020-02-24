using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ScrumProjectOne
{

    class Partitionierung
    {
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };
        static DirectoryInfo info = new DirectoryInfo(@"C:\Users\Administrator\ScrumProjectOne");
        

        public static void fiveNewestFiles()
        {
            List<FileSystemInfo> fsi;
            var aufg1 = info.GetFileSystemInfos().Take(5).OrderBy(x => x.CreationTime);
            fsi = aufg1.ToList();
            Console.WriteLine("Diese letzten 5 erstellten Files in dem Ordner:");
            foreach (var item in fsi)
            {
                Console.WriteLine(item.FullName+ ", "+ item.CreationTime+";");
            }
            
        }



        public static void firstFive()
        {
            List<int> liste = new List<int>();
            var aufg1 = numbers.Take(5);
            liste = aufg1.ToList();
            Console.WriteLine("Die ersten 5 Elemte in der Liste: ");
            foreach (var item in liste)
            {
                Console.Write(item + ", ");
            }
            
        }

        public static void lastFive()
        {
            List<int> liste = new List<int>();
            var aufg1 = numbers.Skip(liste.Count - 5);
            liste = aufg1.ToList();
            Console.WriteLine("Die letzten 5 Elemte in der Liste: ");
            foreach (var item in liste)
            {
                Console.Write(item + ", ");
            }
        }
        public static void notFirstAndLastThree()
        {
            List<int> liste = new List<int>();
            var aufg1 = numbers.Skip(3).Take(liste.Count - 3);
            liste = aufg1.ToList();
            Console.WriteLine("Alle Elemente der Liste bist auf die ersten und letzten Drei: ");
            foreach (var item in liste)
            {
                Console.Write(item + ", ");
            }
        }
        public static void allExpectNull()
        {
            List<int> liste = new List<int>();
            var aufg1 = from num in numbers where num > 0 select 0;
            liste = aufg1.ToList();
            Console.WriteLine("Elemente der Liste nach der Zahl 12: ");
            foreach (var item in liste)
            {
                Console.Write(item + ", ");
            }
        }
        public static void upToTwelvev()
        {
            List<int> liste = new List<int>();
            var aufg1 = numbers.SkipWhile(x => x == 12);
            liste = aufg1.ToList();
            Console.WriteLine("Elemente der Liste nach der Zahl 12: ");
            foreach (var item in liste)
            {
                Console.Write(item + ", ");
            }
        }

        public static void AuswahlVerfahren()
        {
            Console.Clear();
            int auswahl;
            bool filtermenu=true;
            while(filtermenu){
                Console.WriteLine(  "=============================================\n" +
                                    "+             Partitionierung               +\n" +
                                    "=============================================\n");
            Console.WriteLine("Welches Partitionierungsverfahren möchten sie anwenden ?\n" +
                              "\t[1] Die ersten fünf Elemente des Arrays ausgeben. \n" +
                              "\t[2] Die letzten fünf Elemente des Arrays ausgeben.\n" +
                              "\t[3] Alle Elemente bis auf die ersten und letzten drei im Array.\n" +
                              "\t[4] Alle Elemente des Arrays die größer als 0 sind.\n" +
                              "\t[5] Alle Elemente im Array nach der Zwölf.\n" +
                              "\t[6] Die fünf neuesten Dateien in einem Verzeichnis.\n"+
                              "[0] Die ersten fünf Elemente des Arrays ausgeben. \n" 
                              );

            auswahl = Convert.ToInt32(Console.ReadLine());

            switch (auswahl)
            {
                case 1:
                    {
                        firstFive();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case 2:
                    {

                        lastFive();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case 3:
                    {
                        notFirstAndLastThree();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    }
                case 4:
                    {
                        allExpectNull();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    }
                case 5:
                    {

                        upToTwelvev();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case 6:
                    {
                        fiveNewestFiles();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case 0:
                        filtermenu = false;
                        break;

            }}


        }
    }
}
