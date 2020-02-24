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


           Hauptmenu();         

            
            


            Console.ReadLine();
        }
          public static void Hauptmenu()
        {         
            int auswahl;
            bool exitKey = true;
            while (exitKey)
            {
                Console.Clear();
                Console.WriteLine(  "=============================================\n" +
                                    "+++             SrumProjectOne            +++\n" +
                                    "+++   written by the Developer Division   +++\n" +
                                    "=============================================\n" );
                Console.WriteLine(  "=============================================\n" +
                                    "+++                Hauptmenu              +++\n" +
                                    "=============================================\n" +
                                    "Was möchtest du tun?\n" +
                                    "" +
                                    "\t[1] Sortieren\n" +
                                    "\t[2] Filtern\n" +
                                    "\t[3] Partitionieren\n" +
                                    "\t[4] Gruppieren\n" +
                                    "\t[0] Das Programm verlassen.");
                auswahl = Convert.ToInt32(Console.ReadLine());

                switch (auswahl)
                {
                    case 0:
                        {
                            exitKey = false;  
                            Console.Clear();
                            break;
                        }
                    case 1:
                        {
                            Sortieren.AuswahlVerfahren();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {

                            Filter.AuswahlVerfahren();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            Partitionierung.AuswahlVerfahren();
                            Console.Clear();
                            break;
                        }
                    case 4: 
                        Gruppierung.AuswahlVerfahren();
                        break;



                }
            }
        }
    }

}
