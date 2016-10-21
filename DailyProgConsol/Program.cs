using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyProgConsol.AdjacentNumbersConsol;

namespace DailyProgConsol
{
    public class Program
    {
        static void Main(string[] args)
        {
            int iActuallyWantToGo;
            do
            {
            Console.WriteLine("\n\nChose Program");
            Console.WriteLine("1 Answer Number Challenege:");
            string iWantToGo = Console.ReadLine();
                if (int.TryParse(iWantToGo, out iActuallyWantToGo))
                {
                    switch (iActuallyWantToGo)
                    {
                        // Answer Number Challenege
                        case 1:
                            {
                                #region anc
                                Console.WriteLine("Chose direction:");
                                Console.WriteLine("1 anc_colby:");
                                Console.WriteLine("2 anc_connor:");
                                string anc_direction = Console.ReadLine();

                                if(anc_direction == "1")
                                {
                                    AdjacentNumbersConsol.anc_colby colby = new AdjacentNumbersConsol.anc_colby();
                                    colby.Grid();
                                }
                                else if(anc_direction == "2")
                                {
                                    //CALL CONNOR METHOD
                                }
                                else
                                {

                                }

                                break;
                                #endregion
                            }
                        case 2:
                            {
                                Console.WriteLine("Case 2");
                                break;
                            }
                        case 99:
                            {
                                Console.WriteLine("Bye");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Wtf m8... Pick one...");
                                break;
                            }
                    }
                }
            } while (iActuallyWantToGo != 99);            
        }
    }
}
