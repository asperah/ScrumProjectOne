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
        private int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };
        DirectoryInfo info = new DirectoryInfo(@"C:\Users\Administrator\ScrumProjectOne");
        

        public void fiveNewestFiles()
        {
            List<FileSystemInfo> fsi;
            var aufg1 = info.GetFileSystemInfos().Take(5).OrderBy(x=>x.CreationTime);
            fsi = aufg1.ToList();
            Console.WriteLine("Diese letzten 5 erstellten Files in dem Ordner:");
            foreach (var item in fsi)
            {
                Console.WriteLine(item.FullName+ ", "+ item.CreationTime+";");
            }
            
        }



        public void firstFive()
        {
            List<int> liste = new List<int>();
            var aufg1 = numbers.Take(5);
            liste = aufg1.ToList();
            Console.WriteLine("Die ersten 5 Elemte in der Liste: ");
            foreach (var item in liste)
            {                
                Console.Write(item+", ");
            }            
        }

        public void lastFive()
        {
            List<int> liste = new List<int>();
            var aufg1 = numbers.Skip(liste.Count-5);
            liste = aufg1.ToList();
            Console.WriteLine("Die letzten 5 Elemte in der Liste: ");
            foreach (var item in liste)
            {
                Console.Write(item + ", ");
            }
        }
        public void notFirstAndLastThree()
        {
            List<int> liste = new List<int>();
            var aufg1 = numbers.Skip(3).Take(liste.Count-3);
            liste = aufg1.ToList();
            Console.WriteLine("Alle Elemente der Liste bist auf die ersten und letzten Drei: ");
            foreach (var item in liste)
            {
                Console.Write(item + ", ");
            }
        }
        public void allExpectNull()
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
        public void upToTwelvev()
        {
            List<int> liste = new List<int>();
            var aufg1 = numbers.SkipWhile(x=>x==12);
            liste = aufg1.ToList();
            Console.WriteLine("Elemente der Liste nach der Zahl 12: ");
            foreach (var item in liste)
            {
                Console.Write(item + ", ");
            }
        }




    }
}
