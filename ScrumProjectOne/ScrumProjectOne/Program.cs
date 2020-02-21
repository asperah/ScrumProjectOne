using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumProjectOne
{
    class Program
    {
        static void Main(string[] args)
        {



            Partitionierung parti = new Partitionierung();
            Console.WriteLine("Hallo");
            parti.fiveNewestFiles();
            parti.lastFive();
            parti.notFirstAndLastThree();
            parti.firstFive();
            parti.allExpectNull();
            parti.upToTwelvev();
            
           

            Console.ReadLine();
        }
    }
}
