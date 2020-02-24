using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ScrumProjectOne
{
    class Menu
    {
        public static void MainMenu()
        {         
            int auswahl;
            bool exitKey = true;
            while (exitKey)
            {
                Console.WriteLine(  "=============================================\n" +
                                    "+++                Hauptmenu              +++\n" +
                                    "=============================================\n" +
                                    "Was möchtest du tun?\n" +
                                    "" +
                                    "\t[1] Sortieren\n" +
                                    "\t[2] Filtern\n" +
                                    "\t[3] Partitionieren\n" +
                                    "\t[0] Das Programm verlassen.");
                auswahl = Convert.ToInt32(Console.ReadLine());

                switch (auswahl)
                {
                    case 0:
                        {
                            exitKey = false;                           
                            break;
                        }
                    case 1:
                        {
                            Sortieren.AuswahlVerfahren();
                            break;
                        }
                    case 2:
                        {

                            Filter.AuswahlVerfahren();
                            break;
                        }
                    case 3:
                        {
                            Partitionierung.AuswahlVerfahren();
                            break;
                        }



                }
            }
        }
    } 
}
